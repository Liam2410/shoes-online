using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ShoesOnline.Repositories.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using static ShoesOnline.Repositories.Admin.AdminRes;
using Shoes = ShoesOnline.Models.Admin.Shoes;

namespace ShoesOnline.Controllers.Admin
{
    public class AdminController : Controller
    {

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult QLSanPham()
        {

            List<Shoes> lstShoes = GetAll();

            ViewBag.DanhSachGiay = lstShoes;

            return View();
        }


        public ActionResult DonHang()
        {
            return View();
        }

        public ActionResult CreateShoes()
        {
            return View();
        }

        // POST: AccountController/Register
        [HttpPost]
        public ActionResult CreateShoes(IFormCollection collection)
        {


            //Lấy dữ liệu từ form
            var name = collection["name"];
            var type = collection["type"];
            var size = int.Parse(collection["size"]);
            var price = int.Parse(collection["price"]);
            var quantity = int.Parse(collection["quantity"]);
            var desciption = collection["desciption"];
            var imagepath = collection["imagepath"];

            var result = InsertShoes(name, type, size, price, quantity, desciption);

            if (result)
            {
                return Redirect("/Admin/QLSanPham");
            }
            else
            {
                ViewBag.Loi = "Thêm sản phẩm không thành công";
                return View();
            }

        }

        public ActionResult DetailsShoes(int ID)
        {
            Shoes shoes = GetShoes(ID);

            ViewBag.Giay = shoes;

            return View();
        }

        public ActionResult EditShoes(int ID)
        {
            Shoes shoes = GetShoes(ID);

            ViewBag.Giay = shoes;

            return View();
        }

        // POST: AccountController/Register
        [HttpPost]
        public ActionResult EditShoes(IFormCollection collection, int ID)
        {
            //Lấy dữ liệu từ form
            var name = collection["name"];
            var type = collection["type"];
            var size = int.Parse(collection["size"]);
            var price = int.Parse(collection["price"]);
            var quantity = int.Parse(collection["quantity"]);
            var desciption = collection["desciption"];
            var imagepath = collection["imagepath"];

            var result = UpdateShoes(ID, name, type, size, price, quantity, desciption);

            if (result)
            {
                return Redirect("/Admin/QLSanPham");
            }
            else
            {
                ViewBag.Loi = "Sửa sản phẩm không thành công";
                return View();
            }

        }
        
        public ActionResult DeleteShoes(int ID)
        {
            ViewBag.ID = ID;
            return View();
        }

        // POST: AccountController/Register
        [HttpPost]
        public ActionResult DeleteShoes(IFormCollection collection)
        {

            var result = RemoveShoes( int.Parse(collection["ID"].ToString()) );

            if (result)
            {
                return Redirect("/Admin/QLSanPham");
            }
            else
            {
                ViewBag.Loi = "Xóa sản phẩm không thành công";
                return View();
            }
        }
    }
}
