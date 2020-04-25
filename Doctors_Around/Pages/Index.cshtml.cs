﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace Doctors_Around.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public string[] Advices = {"KYS","Stay At Home","Cyka" ,"Random Advice Number 3","Generic Advice Number 4" };
        public string advice;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
            Random rnd = new Random();
            int adv = rnd.Next(5);
            advice = Advices[adv];
        }

        public void OnGet()
        {

        }
    }
}
