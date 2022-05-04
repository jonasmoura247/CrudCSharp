using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks; 
using Microsoft.AspNetCore.Mvc;

namespace crudCSharp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusicaController : ControllerBase
    {
        [HttpGet]

        public string Get ()
        {
            return "ok"; 
        }
    }
}