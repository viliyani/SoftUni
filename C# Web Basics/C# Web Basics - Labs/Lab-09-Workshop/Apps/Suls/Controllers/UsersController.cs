using Suls.Services;
using Suls.ViewModels.Users;
using SUS.HTTP;
using SUS.MvcFramework;
using System.ComponentModel.DataAnnotations;

namespace Suls.Controllers
{
    public class UsersController : Controller
    {
        private readonly IUsersService usersService;

        public UsersController(IUsersService usersService)
        {
            this.usersService = usersService;
        }

        public HttpResponse Login()
        {
            if (IsUserSignedIn())
            {
                return Redirect("/");
            }

            return View();
        }

        [HttpPost]
        public HttpResponse Login(string username, string password)
        {
            if (IsUserSignedIn())
            {
                return Redirect("/");
            }

            var userId = usersService.GetUserId(username, password);

            if (userId == null)
            {
                return Error("Invalid username or password.");
            }

            SignIn(userId);

            return Redirect("/");
        }

        public HttpResponse Register()
        {
            if (IsUserSignedIn())
            {
                return Redirect("/");
            }

            return View();
        }

        [HttpPost]
        public HttpResponse Register(RegisterInputModel input)
        {
            if (IsUserSignedIn())
            {
                return Redirect("/");
            }

            if (string.IsNullOrEmpty(input.Username) || input.Username.Length < 5 || input.Username.Length > 20)
            {
                return Error("Username should be between 5 and 20 charaters!");
            }

            if (string.IsNullOrWhiteSpace(input.Email) || !new EmailAddressAttribute().IsValid(input.Email))
            {
                return Error("Invalid email.");
            }

            if (input.Password == null || input.Password.Length < 6 || input.Password.Length > 20)
            {
                return Error("Invalid password. The username should be between 6 and 20 characters.");
            }

            if (input.Password != input.ConfirmPassword)
            {
                return Error("Password should be the same.");
            }

            if (!usersService.IsUsernameAvailable(input.Username))
            {
                return Error("Username already taken.");
            }

            if (!usersService.IsUsernameAvailable(input.Email))
            {
                return Error("Email already taken.");
            }

            usersService.CreateUser(input.Username, input.Email, input.Password);

            return Redirect("/users/login");
        }

        public HttpResponse Logout()
        {
            if (!IsUserSignedIn())
            {
                return Error("Only logged-in users can logout.");
            }

            SignOut();

            return Redirect("/");
        }
    }
}
