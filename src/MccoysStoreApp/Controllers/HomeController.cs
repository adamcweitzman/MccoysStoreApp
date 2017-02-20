using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MccoysStoreApp.Models;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MccoysStoreApp.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
        //public Dictionary<string, List<string>> StoreNamesAndLinks { get; set; }
        public IStoreRepository storeRepository { get; set; }

        public HomeController(IStoreRepository storeRepository)
        {
            this.storeRepository = storeRepository;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/stores")]
        public IActionResult Stores()
        {
            return View();
        }
    }
}
