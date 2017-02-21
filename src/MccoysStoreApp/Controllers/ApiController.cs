using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MccoysStoreApp.Models;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace MccoysStoreApp.Controllers
{
    [Route("[controller]")]
    public class ApiController : Controller
    {

        public IStoreRepository storeRepository { get; set; }

        public ApiController(IStoreRepository storeRepository)
        {
            this.storeRepository = storeRepository;
        }
        // GET: api/values
        [HttpGet("store/add")]
        public IActionResult Index()
        {
            return View(new Store());
        }

       [HttpPost("store/add")]
        public IActionResult Post(Store store)
        {
            storeRepository.Add(store);
            return View();
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
