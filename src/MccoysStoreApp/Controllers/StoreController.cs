using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MccoysStoreApp.Models;
using System.Reflection;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MccoysStoreApp.Controllers
{
    [Route("[controller]")]
    public class StoreController : Controller
    {
        public IStoreRepository storeRepository { get; set; }

        public StoreController(IStoreRepository storeRepository)
        {
            this.storeRepository = storeRepository;
        }
        // GET api/values/5
        [HttpGet("{id}")]
        public IActionResult GetDetails(string id)
        {
            Store storeDetails = storeRepository.GetDetails(id);
            if (string.IsNullOrEmpty(storeDetails.StoreManagerName)) storeDetails.StoreManagerName = "UNKNOWN";
            if (string.IsNullOrEmpty(storeDetails.ClosingTime)) storeDetails.ClosingTime = "UNKNOWN";
            if (string.IsNullOrEmpty(storeDetails.OpeningTime)) storeDetails.OpeningTime = "UNKNOWN";
            if (string.IsNullOrEmpty(storeDetails.StoreName) || string.IsNullOrEmpty(storeDetails.StoreNumber))
            {
                storeDetails.OpeningTime = "";
                storeDetails.ClosingTime = "";
                storeDetails.StoreManagerName = "";
                storeDetails.StoreName = "";
                storeDetails.StoreNumber = "";
            }

            return View(storeDetails);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
