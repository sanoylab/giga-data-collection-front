using gdcp.Data;
using gdcp.Data.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gdcp.App.Controllers
{
    public class SchoolController : Controller
    {
        private readonly ISchoolService _schoolService;
        [BindProperty]

        public School School { get; set; }

        public SchoolController(ISchoolService schoolService)
        {
            _schoolService = schoolService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Registration()
        {
            return View();
        }

        #region API CALLS
        [HttpGet]
        public IActionResult GetAll()
        {
            return Json(new { data = _schoolService.GetAll() });
        }

        #endregion
    }
}
