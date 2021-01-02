using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using bs23_project_midLevel.Models;
using bs23_project_midLevel.Interface;
using Microsoft.AspNetCore.Identity;

namespace bs23_project_midLevel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPost _postRepo;
        private static UserManager<ApplicationUser> _userManager;
    
        public HomeController(ILogger<HomeController> logger, IPost postRepo, UserManager<ApplicationUser> userManager)
        {
            _logger = logger;
            _postRepo = postRepo;
            _userManager = userManager;
        }


        public IActionResult Index()
        {
            var post = _postRepo.GetById(1);
            return View(post);
            //var post = _postRepo.GetAll();
            //return View(post);
        }



        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
