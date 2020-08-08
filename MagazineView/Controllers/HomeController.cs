using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MagazineView.Models;

namespace MagazineView.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            HomePageModel hmModel = new HomePageModel();
            hmModel.IssueDetails = new List<IssueDataModel>() { new IssueDataModel("img/001.jpg"),
                                                                 new IssueDataModel("img/002.jpg"),
                                                                 new IssueDataModel("img/003.jpg"),
                                                                 new IssueDataModel("img/004.jpg"),
                                                                 new IssueDataModel("img/005.jpg"),
                                                                 new IssueDataModel("img/006.jpg"),
                                                                 new IssueDataModel("img/007.jpg"),
                                                                 new IssueDataModel("img/009.jpg"),
                                                                 new IssueDataModel("img/010.jpg"),
                                                                 new IssueDataModel("img/015.jpg"),
                                                                 new IssueDataModel("img/022.jpg"),};

            return View(hmModel);
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
