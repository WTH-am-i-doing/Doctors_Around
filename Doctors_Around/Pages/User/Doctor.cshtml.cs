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
            Full_Name = "Aimen Hospital",
            accountType = Core.AccountType.Hospital,
            City = "Oran",
            Country = "Algeria",
            Email = "Aimen@uRDead.net",
            Full_Adress = "Nobody Ducking Place",
            Password = "Crapinattos",
            Phone_number = "+213 QWERTYUIO",
            RequestedCases = new List<Core.Case>() { new Core.Case() {
                Patient_Name="Mazouni Abdelkader",
                Medicins=new List<string>(){"ESISBA-Phlorine","Takhmamin"},
                PreviousIllnesses=new List<string>(){"Sneeze"},
                Symptoms=new List<string>(){"Coughing","Hard Breathing","Sneezing","COVID"}
            },new Core.Case() {
                Patient_Name="Zairi Random",
                Medicins=new List<string>(){"ESISBA-Phlorine","Crapine","Heroine"},
                PreviousIllnesses=new List<string>(){"None I Guess"},
                Symptoms=new List<string>(){"COVID-19 Simpsons"}
            },new Core.Case() {
                Patient_Name="Kho Riad",
                Medicins=new List<string>(){"non-ESISBA-Phlorine","Leagueoflogin"},
                PreviousIllnesses=new List<string>(){"Toxicity"},
                Symptoms=new List<string>(){"Toxicity"}
            } }
        };
        public void OnGet()
        {

        }
    }
}