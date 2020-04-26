using System;
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
        public string[] Advices = {"Don't Touch Stuff Barehanded It Can Containt Anything","Stay At Home, Stay Safe","Think About The People You Can Hurt If You Get The Illness" ,"Clean Your Hand Always","If You Think You Have The Symptoms Go To The Nearest Hospital To Get Checked And Take Safety Measures" };
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
