using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Medical_Diagnosis.Controllers
{
    public class Patient_SignUpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
