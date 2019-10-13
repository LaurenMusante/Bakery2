using Microsoft.AspNetCore.Mvc;
using Bakery2.Models;
using System.Collections.Generic;
using System;


namespace Bakery2.Controllers
{
    public class OrderController : Controller
    {

        [HttpGet("vendors/{Id}/orders/new")]
        public ActionResult New(int Id)
        {
            return View(Vendor.vendors[Id - 1]);
        }

        [HttpPost("/orders/show")]
        public ActionResult Create(string orderTitle, int orderQuantity, int orderPrice, int orderDate, int vendorId)
        {
            Order myOrder = new Order(orderTitle, orderQuantity, orderPrice, orderDate);
            Vendor.vendors[vendorId - 1].orders.Add(myOrder);
            return RedirectToAction("Show", "Vendor");
        }

    }
}

    

