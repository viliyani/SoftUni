using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace MyAspNetCoreApp.Controllers
{
    public class IdentityTestController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;
        private readonly SignInManager<IdentityUser> signInManager;
        private readonly RoleManager<IdentityRole> roleManager;

        public IdentityTestController(
            UserManager<IdentityUser> userManager,
            SignInManager<IdentityUser> signInManager,
            RoleManager<IdentityRole> roleManager
            )
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            this.roleManager = roleManager;
        }

        public async Task<IActionResult> Create()
        {
            var user = new IdentityUser
            {
                Email = "User1@abv.bg",
                UserName = "User1@abv.bg",
                EmailConfirmed = true,
                PhoneNumber = "3214125",
            };

            await this.userManager.CreateAsync(user, "User1@abv.bg");
            return this.Content("User created");
        }

        public async Task<IActionResult> Login()
        {
            await this.signInManager.PasswordSignInAsync("User1@abv.bg", "User1@abv.bg", true, true);

            return this.Redirect("/");

        }

        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return this.Redirect("/");
        }


        public async Task<IActionResult> WhoAmI()
        {
            var user = await this.userManager.GetUserAsync(this.User);
            return this.Json(user);
        }

    }
}
