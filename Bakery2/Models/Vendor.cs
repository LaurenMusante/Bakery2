using System.Collections.Generic;


namespace Bakery2.Models
{
    public class Vendor
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Id { get; }
        public static List<Order> orders = new List<Order> {};
        public static List<Vendor> vendors = new List<Vendor> {};

        public Vendor (string name, string description)
        {
            Name = name;
            Description = description;
            vendors.Add(this);
            // Id = orders.Count;
        }

        public static List<Vendor> GetAll()
        {
            return Vendor.vendors; //because it's static, it has to be Vendors.orders instead of just "orders." Like Math is a static method. Name of 
        }

        public static void ClearAll()
        {
            orders.Clear();
        }

        // public static Order Find(int searchId)
        // {
        //     return orders[searchId-1]; //might not need this one
        // }
    }
}