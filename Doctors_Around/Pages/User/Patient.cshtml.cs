using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Doctors_Around.Pages.User
{
    public class PatientModel : PageModel
    {
        public Core.User user = new Core.User() {
            Full_Name = "Riad Fentazi",
            accountType = Core.AccountType.Patient,
            City = "Algiers",
            Country = "Algeria",
            Email = "Riad@Fentazi.net",
            Full_Adress = "Nobody Cares But Anyway"
        };
        public PatientModel()
        {

        }
        public void OnGet()
        {

        }
    }
}