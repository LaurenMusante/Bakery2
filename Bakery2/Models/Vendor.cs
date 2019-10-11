using System.Collections.Generic;

namespace Bakery.Models
{
    public class Vendor
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; }
        public static List<Order> orders = new List<Order> {};

        public Vendor (string name, string description)
        {
            Name = name;
            Description = description;
            orders.Add(this);
            Id = orders.Count;
        }

        public static List<Order> GetAll()
        {
            return orders;
        }

        public static void ClearAll()
        {
            orders.Clear();
        }

        public static Order Find(int searchId)
        {
            return orders[searchId-1]; //might not need this one
        }
    }
}