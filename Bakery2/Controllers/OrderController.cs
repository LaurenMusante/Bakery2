[HttpGet("/orders")]
public ActionResult Index()
{
    List<Order> allOrders = Vendor.GetAll(); //because GetAll is a static method of my Vendor class
    return View(allOrders);
}
[HttpPost("/orders/new")]
public ActionResult Create(string name, string description)
{
    Order myOrder = new Order(name, description);
    return RedirectToAction("Index");
}

//??????? all of this