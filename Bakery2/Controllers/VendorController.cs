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
            List<Order> allOrders = Order.GetAll();
            return View (allOrders);
        }
    }
}