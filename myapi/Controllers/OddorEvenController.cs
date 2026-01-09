using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using myapi.Services;

namespace myapi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OddorEvenController : ControllerBase
    {
        private readonly OddOrEvenServices _oddOrEvenServices;

        public OddorEvenController(OddOrEvenServices oddOrEvenServices)
        {
            _oddOrEvenServices=oddOrEvenServices;
        }

        [HttpGet]
        [Route("OddOrEven/{number}")]
        
        public string OddOrEven(int number)
        {
            return _oddOrEvenServices.OddOrEven(number);
        }
    }
}