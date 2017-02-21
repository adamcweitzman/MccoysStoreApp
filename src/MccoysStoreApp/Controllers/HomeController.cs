using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MccoysStoreApp.Models;
using MccoysStoreApp.ViewModels;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MccoysStoreApp.Controllers
{
    [Route("/")]
    public class HomeController : Controller
    {
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
            StoreViewModel storeViewModel = new StoreViewModel();
            var stores = storeRepository.StoreList();
            storeViewModel.StoreList = new List<Store>();
            foreach (var store in stores)
            {
                if (string.IsNullOrEmpty(store.StoreName) || string.IsNullOrEmpty(store.StoreNumber))
                    continue;
                storeViewModel.StoreList.Add(store);
            }

            return View(storeViewModel);
        }
    }
}
