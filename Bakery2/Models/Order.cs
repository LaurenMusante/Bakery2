using System.Collections.Generic;

namespace Bakery2.Models
{
    public class Order
    {
        public string Title { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public int Date { get; set; }
    
        public Order (string title, int quantity, int price, int date)
        {
            Title = title;
            Quantity = quantity;
            Price = price;
            Date = date;
        }


    }

}