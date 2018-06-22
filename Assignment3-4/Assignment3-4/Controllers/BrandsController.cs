using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment3_4.Models;
using System.Data.Entity;

namespace Assignment3_4.Controllers
{
    public class BrandsController : Controller
    {
        private ApplicationDbContext _context;

        public BrandsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Brands
        public ActionResult Index()
        {
            var brands = _context.Brands.ToList();
            return View(brands);
        }

        public ActionResult AvailablePhones(int brandID)
        {
            var phones = _context.Phones.Include(m => m.Brand).Select(m => m.BrandID == brandID);
            return View(phones);
        }
    }
}