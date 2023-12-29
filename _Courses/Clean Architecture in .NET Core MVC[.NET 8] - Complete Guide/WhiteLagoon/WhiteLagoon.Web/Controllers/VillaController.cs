﻿using Microsoft.AspNetCore.Mvc;
using WhiteLagoon.Domain.Entities;
using WhiteLagoon.Infrastructure.Data;

namespace WhiteLagoon.Web.Controllers
{
    public class VillaController : Controller
    {
        private readonly ApplicationDbContext _db;

        public VillaController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var villas = _db.Villas.ToList();

            return View(villas);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Villa villa)
        {
            if(villa.Name ==villa.Description)
            {
                ModelState.AddModelError("name", "The provided description should be different from the name.");
            }

            if (ModelState.IsValid)
            {
                _db.Villas.Add(villa);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(villa);
        }


        public IActionResult Update( int villaId)
        {
            var villa = _db.Villas.FirstOrDefault(u=>u.Id == villaId);
            if (villa == null) {
                return NotFound();
            }
            return View(villa);
        }



    }
}
