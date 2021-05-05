using MyFirstMvcApp.Services;
using SUS.HTTP;
using SUS.MvcFramework;
using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace MyFirstMvcApp.Controllers
{
    public class UsersController : Controller
    {
        private IUsersService usersService;

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

        [HttpPost("/users/login")]
        public HttpResponse Login(string username, string password)
        {
            if (IsUserSignedIn())
            {
                return Redirect("/");
            }

            var userId = usersService.GetUserId(username, password);

            if (userId == null)
            {
                return Error("Invalid username or password");
            }

            SignIn(userId);

            return Redirect("/cards/all");
        }

        public HttpResponse Register()
        {
            if (IsUserSignedIn())
            {
                return Redirect("/");
            }

            return View();
        }

        [HttpPost("/users/register")]
        public HttpResponse Register(string username, string email, string password, string confirmPassword)
        {
            if (IsUserSignedIn())
            {
                return Redirect("/");
            }

            if (username == null || username.Length < 5  || username.Length > 20)
            {
                return Error("Invalid username. The username should be between 5 and 20 characters.");
            }

            if (!Regex.IsMatch(username, @"^[a-zA-Z0-9\.]+$"))
            {
                return Error("Invalid username. Only letters and numbers!");
            }

            if (string.IsNullOrWhiteSpace(email) || !new EmailAddressAttribute().IsValid(email))
            {
                return Error("Invalid email.");
            }

            if (password == null || password.Length < 6 || password.Length > 20)
            {
                return Error("Invalid password. The username should be between 6 and 20 characters.");
            }

            if (password != confirmPassword)
            {
                return Error("Password should be the same.");
            }

            if (!usersService.IsUsernameAvailable(username))
            {
                return Error("Username already taken.");
            }
            
            if (!usersService.IsUsernameAvailable(email))
            {
                return Error("Email already taken.");
            }

            usersService.CreateUser(username, email, password);

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
