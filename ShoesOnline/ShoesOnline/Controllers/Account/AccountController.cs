using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using static ShoesOnline.Repositories.Account.AccountRes;
using AccountModel = ShoesOnline.Models.Account.Account;

namespace ShoesOnline.Controllers.Account
{

    public class AccountController : Controller
    {
        // GET: AccountController/Login
        public ActionResult Login()
        {
            return View();
        }
        
        // POST: AccountController/Login
        [HttpPost]
        public async Task<ActionResult> Login(IFormCollection collection)
        {
            //Lấy dữ liệu từ form
            var emailOrPhone = collection["emailOrPhone"];
            var password = collection["password"];

            var result = CheckLogin(emailOrPhone, password);
            
            if (result != null)
            {
                ClaimsIdentity userIndentity = new ClaimsIdentity(CookieAuthenticationDefaults.AuthenticationScheme);
                ClaimsPrincipal claimsPrincipal = new ClaimsPrincipal(userIndentity);
                userIndentity.AddClaim(new Claim("ID" , result.ID.ToString()));
                userIndentity.AddClaim(new Claim("Fullname", result.Fullname));
                userIndentity.AddClaim(new Claim(ClaimTypes.Role, result.Role));
                
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, claimsPrincipal);
                
                return Redirect("/Other/Index");
            }
            else
            {
                return View();
            }
        }

        public ActionResult Logout()
        {
            HttpContext.SignOutAsync();
            return Redirect("/Account/Login");
        }
        
        // GET: AccountController/Register
        public ActionResult Register()
        {
            return View();
        }
        
        // POST: AccountController/Register
        [HttpPost]
        public ActionResult Register(IFormCollection collection)
        {
            //Lấy dữ liệu từ form
            var fullname = collection["fullname"];
            var email = collection["email"];
            var phone = collection["phone"];
            var gender = collection["gender"];
            var password = collection["password"];

            var result = RegisterAccount(email, phone, password, fullname, gender);

            if (result)
            {
                return Redirect("/Account/Login");
            }
            else
            {
                ViewBag.Loi = "Tạo tài khoản không thành công";
                return View();
            }
        }

    }
}
