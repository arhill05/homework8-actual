using Homework8Actual.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Homework8Actual.Controllers
{
    public class InventoryController : Controller
    {
        private AnimalContext db = new AnimalContext();
        // GET: Animal
        public ActionResult Index()
        {
            List<Animal> animals = db.Animals.ToList();
            foreach (Animal animal in animals)
            {
                if (animal.Description.Length > 199)
                    animal.Description = animal.Description.Remove(200, animal.Description.Length - 200) + "...";
            }
            return View(animals);
        }

        // GET: Animals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Animal animal = db.Animals.Find(id);
            if (animal == null)
            {
                return HttpNotFound();
            }
            return View(animal);
        }
    }
}