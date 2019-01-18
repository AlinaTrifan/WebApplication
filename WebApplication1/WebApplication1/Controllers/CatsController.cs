using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationHomeWork.Models;

namespace WebApplicationHomeWork.Controllers
{
    public class CatsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CatList(Gender? gender, FurColor? furcolor)
        {
            var cats = PopulateCats();
            if (gender.HasValue)
            {
                cats = cats.Where(x => x.Gender == gender.Value).ToList();
                return View(cats);
            }
            if (furcolor.HasValue)
            {
                cats = cats.Where(x => x.FurColor == furcolor.Value).ToList();
                return View(cats);
            }
            return View(cats);
        }

        public List<Cats> PopulateCats()
        {
            List<Cats> cats = new List<Cats>();
            cats.Add(new Cats()
            {
                Name = "Tom",
                Gender = Gender.Male,
                FurColor = FurColor.Black
            });

            cats.Add(new Cats()
            {
                Name = "Mimi",
                Gender = Gender.Female,
                FurColor = FurColor.Yellow
            });

            cats.Add(new Cats()
            {
                Name = "Albicioasa",
                Gender = Gender.Female,
                FurColor = FurColor.White,
            });

            return cats;
        }
    }
}