﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Doctors_Arround.Core
{
    public class User
    {
        public string Full_Name { get; set; }
        public AccountType accountType { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone_number { get; set; }
        public List<string> Symptoms { get; set; }
        public List<string> Medicins { get; set; }
        public List<string> PreviousIllnesses { get; set; }
        // This Is Activated Only For Doctors
        public List<Case> RequestedCases { get; set; }
        // Doctors Will Be Obliged to Fill These Informations
        public string Country { get; set; }
        public string City { get; set; }
        public string Full_Adress { get; set; }
        public string Specialty { get; set; }
        
    }
}