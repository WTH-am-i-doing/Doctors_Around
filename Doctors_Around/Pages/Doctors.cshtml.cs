using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Doctors_Around.Data;

namespace Doctors_Around.Pages
{
    public class DoctorsModel : PageModel
    {
        //private IFirebaseLoginHelper helper = new IFirebaseLoginHelper();
        public List<Core.User> Doctors = new List<Core.User>() {new Core.User() {accountType = Core.AccountType.Clinic,
                Full_Name ="Testing Clinic",
                City="Oran",
                Country="Algeria",
                Email="Email@gmail.com",
                Full_Adress="Random Adress,Oran,Algeria",
                Password="NewPassword",
                Phone_number="+213 010101010",
                Specialty="Surgeon"
            },new Core.User() {
                accountType = Core.AccountType.Doctor,
                Full_Name ="Testing Doctor",
                City="Oran",
                Country="Algeria",
                Email="Email@gmail.com",
                Full_Adress="Random Adress,Oran,Algeria",
                Password="NewPassword",
                Phone_number="+213 010101010",
                Specialty="Surgeon"
            },new Core.User() {
                accountType = Core.AccountType.Patient,
                Full_Name ="Testing Patient",
                City="Oran",
                Country="Algeria",
                Email="Email@gmail.com",
                Full_Adress="Random Adress,Oran,Algeria",
                Password="NewPassword",
                Phone_number="+213 010101010",
                Specialty="Surgeon"
            },new Core.User() {
                accountType = Core.AccountType.Hospital,
                Full_Name ="Testing Hospital",
                City="Oran",
                Country="Algeria",
                Email="Email@gmail.com",
                Full_Adress="Random Adress,Oran,Algeria",
                Password="NewPassword",
                Phone_number="+213 010101010",
                Specialty="Surgeon"
            }};

        public void OnGet()
        {
            Doctors = Doctors.Where(d => d.accountType != Core.AccountType.Patient).ToList();
            //var docs = await helper.GetAllPersons();
            //Doctors = docs.Where(u => u.accountType != Core.AccountType.Patient);
        }
        public void OnPost()
        {
        }
    }
}