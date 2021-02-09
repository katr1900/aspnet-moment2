using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moment2.Models;
using System.Text.Json;

namespace Moment2.Controllers
{
    public class FoodController : Controller
    {
        
       
        public IActionResult Pasta()
        {

           
            var pastas = new List<Pasta>
            {
                new Pasta
                {
                    Id = 1,
                    Name = "Baconpasta",


                }
            };
           
            ViewData["Pastas"] = pastas;
            return View();
        }

        [HttpGet]
        public IActionResult SeaFood()
        {
            var seafoodString = HttpContext.Session.GetString("seafood");
            if (seafoodString == null)
            {
                var seafood = new SeaFood();
                ViewBag.Seafoods = seafood.GetAll();
            }
            else
            {
                var seafood = JsonSerializer.Deserialize<SeaFood>(seafoodString);
                ViewBag.Seafoods = seafood.GetAll();
            }
            
            return View();
        }
        [HttpPost]
        public IActionResult SeaFood(SeaFood request)
        {
            var seafoodString = HttpContext.Session.GetString("seafood");
            SeaFood seafood;
            if (seafoodString == null)
            {
                seafood = new SeaFood();
            }
            else
            {
                seafood = JsonSerializer.Deserialize<SeaFood>(seafoodString);
            }
            seafood.Save(request);
            ViewBag.Seafoods = seafood.GetAll();
            seafoodString = JsonSerializer.Serialize<SeaFood>(seafood);
            HttpContext.Session.SetString("seafood", seafoodString);
            return View();
        }

        public IActionResult Meat()
        {
            var meats = new List<Meat>
            {
                new Meat
                {
                    Id = 3,
                    Name = "Pork"
                }
            };
            return View(meats);
        }

            
    }
}
