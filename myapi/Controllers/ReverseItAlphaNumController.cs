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
    public class ReverseItAlphaNumController : ControllerBase
    {
        private readonly ReverseItAlphaNumServices _reverseItAlphaNumServices;

        public ReverseItAlphaNumController(ReverseItAlphaNumServices reverseItAlphaNumServices)
        {
            _reverseItAlphaNumServices = reverseItAlphaNumServices;
        }

        [HttpGet]
        [Route("ReverseItAlphaNum/{LettersAndDigits}")]
        
        public string ReverseItAlphaNum(string LettersAndDigits)
        {
          return _reverseItAlphaNumServices.ReverseItAlphaNum(LettersAndDigits);
        }
    }
}