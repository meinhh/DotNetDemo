using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiDemo.Models;

namespace WebApiDemo.Controllers
{
    [Route("api/[controller]/[action]")]
    public class TransformController : Controller
    {
        [HttpGet]
        public IActionResult IsAlive()
        {
            return Ok(true);
        }

        [HttpPost]
        public IActionResult Transform([FromBody]Human human)
        {
            if (human.Name.ToLower() == "omer")
                return BadRequest(new Exception("Already a Pokemon"));

            var pokemon = new Pokemon
            {
                Name = human.Name,
                Evolutions = human.Age,
                FavoriteBerry = human.FavoriteFood,
                Owner = null
            };

            return Json(pokemon);
        }
    }
}
