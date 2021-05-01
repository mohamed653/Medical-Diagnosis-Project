using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Medical_Diagnosis.Models;
using Microsoft.AspNetCore.Mvc;

namespace Medical_Diagnosis.Controllers
{
    public class LoginController : Controller
    {

        private readonly MedicalDBContext _context;

        public LoginController(MedicalDBContext context)
        {
            _context = context;
        }

        public IActionResult Index(string? message)
        {
            ViewBag.message = message;
            return View();
        }

       

        [HttpPost]
        public RedirectToActionResult Login(TblUser user)
        {


                var checkUser= _context.TblUsers.FirstOrDefault(u => u.Mail == user.Mail && u.Password == user.Password);

                if (checkUser != null)
                {
                    return RedirectToAction("Index","Home",checkUser.Mail);
                }


            return RedirectToAction("Index",new { message = "No User" });



        }
    }
}
