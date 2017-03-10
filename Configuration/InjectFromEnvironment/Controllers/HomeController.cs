using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace InjectToController.Controllers
{
    public class HomeController : Controller
    {
        private MyOption myoption;
        private TwitterClientOption twitterClientOption;

        public HomeController(IOptions<MyOption> myoption, IOptions<TwitterClientOption> twitterClientOption)
        {
            this.myoption = myoption.Value;
            this.twitterClientOption = twitterClientOption.Value;
        }
        public IActionResult Index()
        {
            ViewData["SecertKey"] = myoption.SecretKey;
            ViewData["SecertValue"] = myoption.SecretValue;
            ViewData["ClientId"] = twitterClientOption.ClientId;
            ViewData["ClientSecret"] = twitterClientOption.ClientSecret;
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
