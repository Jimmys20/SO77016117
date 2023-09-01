using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace SO77016117.Pages.AdminPanel
{
    public class LoginModel : PageModel
    {
        public async Task<IActionResult> OnPostLoginAsync()
        {
            await HttpContext.SignInAsync("Cookies", new ClaimsPrincipal(
                new ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim(ClaimTypes.NameIdentifier, Guid.NewGuid().ToString())
                    },
                    "Cookies")
                ));

            return Redirect("/AdminPanel/Index");
        }
    }
}
