using SUS.HTTP;
using SUS.MvcFramework;

namespace MyFirstMvcApp.Controllers
{
    public class UsersController : Controller
    {
        public HttpResponse Login()
        {
            return View();
        }

        [HttpPost("/users/login")]
        public HttpResponse DoLogin()
        {
            return Redirect("/");
        }

        public HttpResponse Register()
        {
            return View();
        }

        [HttpPost("/users/register")]
        public HttpResponse DoRegister()
        {
            return Redirect("/");
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
