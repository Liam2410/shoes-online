using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using static ShoesOnline.Repositories.Customer.CustomerRes;
using ShoesModel = ShoesOnline.Models.Customer.Shoes;

namespace ShoesOnline.Controllers.Customer
{
    public class CustomerController : Controller
    {

        // GET: CustomerController/Index
        public ActionResult Index()
        {
            List<ShoesModel> shoesList = GetAllShoes();
            
            ViewBag.DanhSachGiay = shoesList;
            return View("../Customer/Index");
        }
        
        // GET: CustomerController/Detail/:ID
        public ActionResult DetailProduct(int ID)
        {
            var shoes = GetShoesById(ID);

            ViewBag.Giay = shoes;
            return View("../Customer/DetailProduct");
        }
        
        // GET: CustomerController/News
        public ActionResult News()
        {
            return View("../Customer/News");
        }
        
        // GET: CustomerController/Checkout
        public ActionResult Checkout()
        {
            return View("../Customer/Checkout");
        }



        // GET: CustomerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
