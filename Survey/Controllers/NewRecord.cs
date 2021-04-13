using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Survey.Models;

namespace Survey.Controllers
{
    public class NewRecord : Controller
    {
        private readonly ConnectionStringClass _cc;
        public NewRecord(ConnectionStringClass cc)
        {
            _cc = cc;

        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(SurveyClass sc)
        {
            _cc.Add(sc);
            _cc.SaveChanges();
            ViewBag.message = "The Record is saved successfully";
            return View();

        }
    }
}

