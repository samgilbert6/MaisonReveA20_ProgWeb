using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MaisonReve.Database.Models;
using MaisonReve.Database.Repository;
using Microsoft.AspNetCore.Mvc;

namespace MaisonReve.Web.Controllers
{
    public class BuildingController : Controller
    {
        private BuildingRepo _repo;

        public BuildingController(BuildingRepo repo)
        {
            this._repo = repo;
        }
        public IActionResult Index()
        {

           var model = this._repo.GetAll();

            return View(model);
        }

        public IActionResult Delete(int id)
        {
            var model = this._repo.GetById(id);
            return View(model);
        }

        [HttpPost,ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {

                this._repo.Remove(id);

            return RedirectToAction(nameof(Index));
        }


        public IActionResult Create()
        {
        
        return View(new Building());
        }
                
        [HttpPost]
        public IActionResult Create(Building model)
        {

            if(ModelState.IsValid){
                 this._repo.Add(model);

                return RedirectToAction(nameof(Index));
            }
      

            //TODO: Implement Realistic Implementation
            return View(model);
        }


        public IActionResult Edit(int id)
        {
         var model = this._repo.GetById(id);

        return View(model);
        }
                
        [HttpPost]
        public IActionResult Edit(Building model)
        {

            if(ModelState.IsValid){
                 this._repo.Edit(model);

                return RedirectToAction(nameof(Index));
            }
      

            //TODO: Implement Realistic Implementation
            return View(model);
        }

        public IActionResult Details(int id)
        {
                var model = this._repo.GetById(id);

                //TODO: Implement Realistic Implementation
                return View(model);
        }




    }
}