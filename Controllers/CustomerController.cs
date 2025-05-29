using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Server.HttpSys; 
using System.Collections.Generic;
using System.Web;

namespace WebApp.Controllers
{
    public class CustomerController : Controller

    {
        // GET: /Customer/
        public ActionResult Index()
        {
            return View();
        }
        
        // GET: Customer/Details/
        public ActionResult Details(int id)
        {
            return View();
        }
        
        // GET: customer create
        public ActionResult Create()
        {
            return View();
        }
        // POST: /Customer/Create
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                //TODO: insert logic here
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        // GET: /Customer/Edit/5
        public ActionResult Edit(int Id)
        {
            return View();
        }
        //POST: /Customer/Edit/5
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(int Id, FormCollection collection)
        {
            try
            {
                // add update logic here
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
