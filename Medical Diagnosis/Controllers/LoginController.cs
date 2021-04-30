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

        private readonly MedicalDiagnosisContext _context;

        public LoginController(MedicalDiagnosisContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public JsonResult Test()
        {
            Patient patient = _context.Patients.FirstOrDefault(p => p.Id == 1);

            return Json(patient);
        }
    }
}
