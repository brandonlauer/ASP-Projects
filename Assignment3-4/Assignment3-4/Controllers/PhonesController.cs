using Assignment3_4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;

namespace Assignment3_4.Controllers
{
    public class PhonesController : Controller
    {
        //DBContext Object
        private ApplicationDbContext _context;

        public PhonesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Phone
        public ActionResult Index()
        {
            var phones = _context.Phones.ToList();
            return View(phones);
        }

        public ActionResult Details(int id)
        {
            var phone = _context.Phones
                .Include(m => m.Brand)
                .Include(m => m.PhoneType)
                .SingleOrDefault(m => m.ID == id);
            if(phone == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(phone);
            }
        }
    }
}