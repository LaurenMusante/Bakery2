using Microsoft.AspNetCore.Mvc;
using Bakery2.Models;
using System.Collections.Generic;
using System;


namespace Bakery2.Controllers
{
    public class VendorController : Controller

    {
        [HttpGet("/vendors")]
        public ActionResult Index()
        {
            List<Vendor> allVendors = Vendor.GetAll();
            return View(allVendors);
        }

        [HttpGet("/vendors/new")]
        public ActionResult New()
        {
                return View();
        }

        [HttpGet("/vendors/show")]
            public ActionResult Show()
        {
            return View();
        }

        [HttpPost("/vendors/show")]
        public ActionResult Create(string vendorName, string vendorDescription)
        {
            Vendor myVendor = new Vendor(vendorName, vendorDescription);
            return RedirectToAction("Index");
        }
    }
}