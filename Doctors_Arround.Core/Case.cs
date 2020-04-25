using System;
using System.Collections.Generic;
using System.Text;

namespace Doctors_Arround.Core
{
    public class Case
    {
        public string Patient_Name { get; set; }
        public List<string> Symptoms { get; set; }
        public List<string> Medicins { get; set; }
        public List<string> PreviousIllnesses { get; set; }
        public string Response { get; set; }
    }

}
