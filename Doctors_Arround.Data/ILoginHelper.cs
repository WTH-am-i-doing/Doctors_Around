using Doctors_Around.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Doctors_Around.Data
{
    public interface ILoginHelper
    {
        public static User CurrentUser;
        public static bool isAuthenticated;
        IEnumerable<User> GetAllAcounts(string country, string city, string name);
        User GetUserbyEmail(string Email);
        User NewUser(User updateduser);
        int Commit();
    }
    public class InMemoryLoginData : ILoginHelper
    {
        private List<User> users;
        
        public InMemoryLoginData()
        {
            users = new List<User>(){
                new Core.User() {id=1,Full_Name = "Riad",accountType = Core.AccountType.Patient,City = "Algiers",Country = "Algeria",Email = "Riad@gmail.com",Full_Adress = "",Medicins=new List<string>() {"Vitamine A" },Password="Password",Phone_number="None",PreviousIllnesses=new List<string>() { "Cold" },Symptoms=new List<string>() { "Coughing", "Hard Breathing"}},
                new Core.User() {id=2,Full_Name = "Aimen",accountType = Core.AccountType.Patient,City = "Algiers",Country = "Algeria",Email = "Aimen@gmail.com",Full_Adress = "",Medicins=new List<string>() {"None" },Password="Password",Phone_number="None",PreviousIllnesses=new List<string>() { "Cold" },Symptoms=new List<string>() { "Coughing", "Hard Breathing"}},
                new Core.User() {id=3,Full_Name = "Abdelkader",accountType = Core.AccountType.Patient,City = "Algiers",Country = "Algeria",Email = "Aek@gmail.com",Full_Adress = "",Medicins=new List<string>() {"Vitamine A" },Password="Password",Phone_number="None",PreviousIllnesses=new List<string>() { "Cold" },Symptoms=new List<string>() { "Coughing", "Hard Breathing"}},
                new Core.User() {id=4,Full_Name = "Dave",accountType = Core.AccountType.Doctor,Country = "USA",City = "New York",Email = "Dave@gmail.com",Full_Adress = "",Password="Password",Phone_number="None",RequestedCases = new List<Case>() },
                new Core.User() {id=5,Full_Name = "Ben",accountType = Core.AccountType.Patient,Country = "UK",City = "London",Email = "Ben@gmail.com",Full_Adress = "",Medicins=new List<string>() {"Vitamine A" },Password="Password",Phone_number="None",PreviousIllnesses=new List<string>() { "Cold" },Symptoms=new List<string>() { "Coughing", "Hard Breathing"}},
                new Core.User() {id=6,Full_Name = "Moscow Hospital",accountType = Core.AccountType.Hospital,Country = "Russia",City = "Moscow",Email = "director@moscowhosp.com",Full_Adress = "",Password="Password",Phone_number="None",RequestedCases=new List<Case>() },
                new Core.User() {id=7,Full_Name = "Karl",accountType = Core.AccountType.Patient,City = "UC Berkley",Country = "USA",Email = "Karl@gmail.com",Full_Adress = "",Medicins=new List<string>() {"None" },Password="Password",Phone_number="None",PreviousIllnesses=new List<string>() { "Cold" },Symptoms=new List<string>() { "Coughing", "Hard Breathing"}},
            };
            User.max_id = 8;
        }

        public int Commit()
        {
            return 0;
        }

        public IEnumerable<User> GetAllAcounts(string country,string city,string name)
        {
            return from u in users
                   where string.IsNullOrEmpty(name) || string.IsNullOrEmpty(city) || string.IsNullOrEmpty(country) || u.Full_Name.ToLower().Contains(name.ToLower()) || u.City.ToLower().Contains(city.ToLower()) || u.Country.ToLower().Contains(country.ToLower())
                   orderby u.Full_Name
                   select u;
        }

        public User GetUserbyEmail(string Email)
        {
            return users.SingleOrDefault(u => u.Email == Email);
        }

        public User NewUser(User newuser)
        {
            users.Add(newuser);
            User.max_id++;
            return newuser;
        }

    }
}
