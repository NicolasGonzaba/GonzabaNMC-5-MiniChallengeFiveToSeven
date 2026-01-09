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
    public class ReverseItNumController : ControllerBase
    {
         private readonly ReverseItNumServices _reverseItNumServices;

        public ReverseItNumController(ReverseItNumServices reverseItNumServices)
        {
            _reverseItNumServices = reverseItNumServices;
        }

        [HttpGet]
        [Route("ReverseItNum/{digits}")]
        
        public string ReverseItNum(int digits)
        {
            return _reverseItNumServices.ReverseItNum(digits);
        }
     }
}