using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HomeWork5.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EntriesController : ControllerBase
    {
        //private readonly EntriesRepo _entriesRepo;

        private readonly ILogger<EntriesController> _logger;

        public EntriesController(ILogger<EntriesController> logger/*, EntriesRepo entriesRepo*/)
        {
            _logger = logger;
           // _entriesRepo = entriesRepo;
        }

        [HttpGet]
        public List<string> GetStrings()
        {
            return new List<string> { "aaa", "bbb", "ccc" };
        }
        /*public List<Entry> Get()
        {
            return _entriesRepo.GetEntries();
        }*/
    }
}
