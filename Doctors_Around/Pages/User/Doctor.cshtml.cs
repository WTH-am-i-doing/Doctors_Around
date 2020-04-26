using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Doctors_Around.Pages.User
{
    public class DoctorModel : PageModel
    {
        public Core.User doc = new Core.User() {
            Full_Name = "Moscow Hospital",
            accountType = Core.AccountType.Hospital,
            City = "Moscow",
            Country = "Russia",
            Email = "director@moscowhospital.ru",
            Full_Adress = "Adress In Moscow",
            Password = "password",
            Phone_number = "+xyz xyzxyzxyz",
            RequestedCases = new List<Core.Case>() { new Core.Case() {
                Patient_Name="Mazouni Abdelkader",
                Medicins=new List<string>(){"Vitamines"},
                PreviousIllnesses=new List<string>(){"None"},
                Symptoms=new List<string>(){"Coughing","Hard Breathing","Sneezing"}
            },new Core.Case() {
                Patient_Name="Zairi Aimen",
                Medicins=new List<string>(){"None"},
                PreviousIllnesses=new List<string>(){"None"},
                Symptoms=new List<string>(){"Head-Ackes","Eye Strain"}
            },new Core.Case() {
                Patient_Name="Sergei Something",
                Medicins=new List<string>(){"Vodka"},
                PreviousIllnesses=new List<string>(){"Toxicity"},
                Symptoms=new List<string>(){"Cold"}
            } }
        };
        public Core.User docc = new Core.User()
        {
            Full_Name = "Algiers General Clinic",
            accountType = Core.AccountType.Clinic,
            City = "Algiers",
            Country = "Algeria",
            Email = "#",
            Full_Adress = "Adress In Algeria",
            Password = "password",
            Phone_number = "+213 xyzxyzxyz",
            RequestedCases = new List<Core.Case>() {  }
        };
        public void OnGet()
        {

        }
    }
}