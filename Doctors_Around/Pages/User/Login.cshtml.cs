using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Doctors_Around.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Doctors_Around.Pages.User
{
    public class LoginModel : PageModel
    {
        //private readonly ILoginHelper loginHelper;
        [BindProperty,Required]
        public string email { get; set; }
        [BindProperty,Required]
        public string psw { get; set; }

        public LoginModel()
        {
            //this.loginHelper = loginHelper;
        }

        public void OnGet()
        {

        }
        public IActionResult OnPost()
        {
            /**if (ModelState.IsValid)
            {
                var user =loginHelper.GetUserbyEmail(email);
                if(user.Password == psw)
                {
                    ILoginHelper.CurrentUser = user;
                    ILoginHelper.isAuthenticated = true;
                    return RedirectToPage("/User/Patient",new {userid = ILoginHelper.CurrentUser.id });
                }
            }*/
            return Redirect("/User/Patient");
        }
    }
}