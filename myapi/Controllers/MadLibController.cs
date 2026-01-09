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
    public class MadLibController : ControllerBase
    {
        private readonly MadLibServices _madLibServices;

    public MadLibController(MadLibServices madLibServices)
    {
        _madLibServices=madLibServices;
    }

        [HttpGet]
        [Route("MadLib/{yourName}/{mood}/{food}/{animal}/{adjective}/{item}/{place}/{activity}")]
        public string Madlib(string yourName, string mood, string food, string animal, string adjective, string item, string place, string activity)
        {
             return _madLibServices.Madlib(yourName, mood, food, animal, adjective, item, place, activity);
        }
    }
}