using EDMCrud.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EDMCrud.Controllers
{
    public class DefaultController : Controller
    {
        private CompanyContext dc = null;
        public DefaultController(CompanyContext db)
        {
            this.dc = db;
        }
        public IActionResult Index()
        {
            List<tblemployee> list = dc.tblemployees.ToList();
            return View(list);
        }

        void FillStates()
        {
            var states = (from n in dc.tblstates
                          orderby n.state_id ascending
                          select new SelectListItem() { Text = n.state_name, Value = n.state_id.ToString() }).ToList();

            ViewBag.states = states;
        }

        public IActionResult Create()
        {
            FillStates();
            return View();
        }
        [HttpPost]
        public IActionResult Create(tblemployee obj)
        {
            if (ModelState.IsValid)
            {
                dc.tblemployees.Add(obj);
                dc.SaveChanges();
                return RedirectToAction("Index");
            }
            FillStates();
            return View(obj);
        }

        public IActionResult Edit(int id)
        {
            FillStates();
            return View(dc.tblemployees.Find(id));
        }
        [HttpPost]
        public IActionResult Edit(tblemployee obj)
        {
            if (ModelState.IsValid)
            {
                dc.tblemployees.Update(obj);
                dc.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            FillStates();
            return View(obj);
        }

        public IActionResult Delete(int id)
        {
            return View(dc.tblemployees.Find(id));
        }
        [HttpPost]
        [ActionName("Delete")]
        public IActionResult DeleteRecord(int id)
        {
            dc.tblemployees.Remove(dc.tblemployees.Find(id));
            dc.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
