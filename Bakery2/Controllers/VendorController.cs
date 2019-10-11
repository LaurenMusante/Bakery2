using Microsoft.AspNetCore.Mvc;
using Bakery.Models;
using System.Collections.Generic;
using System;


namespace Bakery.Controllers
{
    public class BakeryController : Controller

    {
        [HttpGet("/orders")]
        public ActionResult Index()
        {
            List<Order> allOrders = Vendor.GetAll(); //because GetAll is a static method of my Vendor class
            return View (allOrders);
        }
    }
}