using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Items;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Nancy.Json;

namespace Web.Asp.Controllers
{
    public class ApiThoiTietController : Controller
    {
        public string DataThoiTiet { get; private set; }

        // GET: ApiThoiTiet
        public ActionResult Index()
        {
            

            JavaScriptSerializer jss = new JavaScriptSerializer();
            ThoiTietInfo tt = jss.Deserialize<ThoiTietInfo>(DataThoiTiet);
            return View();
        }

        // GET: ApiThoiTiet/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ApiThoiTiet/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ApiThoiTiet/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ApiThoiTiet/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ApiThoiTiet/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ApiThoiTiet/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ApiThoiTiet/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}