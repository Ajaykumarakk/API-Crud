using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using privateconsloe.Models;
using privateconsloe.Repository;
using System.Collections.Generic;

namespace MVC_in_Exercise.Controllers
{
    public class VegetableController : Controller
    {
        VegetableRepository obj;

        public VegetableController()
        {
            obj=new VegetableRepository();
        }
        // GET: VegetableController
        public ActionResult List()
        {
            return View("List",new List<Vegetableinfo>(obj.select()));
        }

        // GET: VegetableController/Details/5
        public ActionResult Details(int Sno)
        {
            var res=obj.select(Sno);
            return View("Details",res);
        }

        // GET: VegetableController/Create
        public ActionResult Create()
        {

            return View("Create",new Vegetableinfo());
        }

        // POST: VegetableController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Vegetableinfo Veg)
        {
            try
            {
                obj.insert(Veg);    
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: VegetableController/Edit/5
        public ActionResult Edit(int Sno)
        {
            var res= obj.select(Sno);
            return View("Edit",res);
        }

        // POST: VegetableController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id,Vegetableinfo Veg)
        {
            try
            {
                Veg.Sno = id;
                obj.Update(Veg);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }

        // GET: VegetableController/Delete/5
        public ActionResult Delete(int Sno)
        {
            var res = obj.select(Sno);
            return View("Delete",res);
        }

        // POST: VegetableController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Remove(int Sno)
        {
            try
            {
                obj.Delete(Sno);
                return RedirectToAction(nameof(List));
            }
            catch
            {
                return View();
            }
        }
    }
}
