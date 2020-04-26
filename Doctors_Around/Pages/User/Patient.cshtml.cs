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
            Email = "Riad@gmail.com",
            Full_Adress = "Nobody Cares",
            Medicins=new List<string>() {"Vitamines","Catalgine","Androstanolone valerate"},
            Password="password",
            Phone_number="None",
            PreviousIllnesses=new List<string>() { "Cold","Fever" },
            Symptoms=new List<string>() { "Coughing", "Hard Breathing"}            
        };
        public void OnGet()
        {

        }
    }
}