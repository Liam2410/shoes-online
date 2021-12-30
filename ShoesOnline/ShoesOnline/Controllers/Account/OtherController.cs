using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace ShoesOnline.Controllers.Account
{
    public class OtherController : Controller
    {
        // GET: OtherController
        [Authorize]
        public ActionResult Index()
        {
            return View("../Account/OtherIndex");
        }
        
        [Authorize(Roles = "Seller")]
        public ActionResult HelloSeller()
        {
            ViewBag.TenNguoiBan = User.FindFirst("Fullname");
            ViewBag.ID = User.FindFirst("ID");
            
            return View("../Account/HelloSeller");
        }

    }
}
