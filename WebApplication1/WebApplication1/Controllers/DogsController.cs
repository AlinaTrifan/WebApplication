using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;
using WebApplicationHomeWork.Models;

namespace WebApplicationHomeWork.Controllers
{
    public class DogsController : Controller
    {
        private DogRepository dogRepository;
        public DogsController()
        {
            dogRepository = DogRepository.Instance;
        }

        public IActionResult DogList()
        {
            return View(dogRepository.GetDogs());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new Dog());
        }

        [HttpPost]
        public IActionResult Create(Dog model)
        {
            if (ModelState.IsValid)
            {
                var maxId = dogRepository.GetDogs().Max(x => x.Id) + 1;
                model.Id = maxId;
                dogRepository.AddDog(model);
                return RedirectToAction("DogList");
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var allExistingDogs = dogRepository.GetDogs();

            Dog dogToEdit = allExistingDogs.Find(x => x.Id == id);

            return View(dogToEdit);
        }

        [HttpPost]
        public IActionResult Edit(Dog model)
        {
            if (ModelState.IsValid)
            {
                Dog myDog = dogRepository.GetDogs().Find(x => x.Id == model.Id);
                TryUpdateModelAsync(myDog);
            }
            return View(model);
        }

       
    }
}