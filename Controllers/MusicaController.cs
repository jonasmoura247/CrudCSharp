using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CrudCSharp.Properties.Model;
using Microsoft.AspNetCore.Mvc;

namespace crudCSharp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MusicaController : ControllerBase
    {
        private static List<Musica> Musica(){
            return new List<Musica>{
                new Musica{Nome = "ACDC", Id = 1}
            };

        }

        [HttpGet]

        public IActionResult Get ()
        {
            return Ok(Musica()); 


            






        }
    }
}