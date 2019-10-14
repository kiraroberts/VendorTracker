using System.Collections.Generic;

namespace VendorTracker.Models
{
    public class VendorTracker
    {
        private static List<Vendor> _instances = new List<Vendor> { };
        public string VendorName { get; set; }
        public int Id { get; }
        public List<Order> Orders { get; set; }
        public Vendor(string vendorName)
        {
            VendorName = vendorName;
            _instances.Add(this);
            Id = _instances.Count;
            Orders = new List<Order> { };
        }
        public static void ClearAll()
        {
            _instances.Clear();
        }
        public static List<Vendor> GetAll()
        {
            return _instances;
        }
        public static Vendor Find(int searchId)
        {
            return _instances[searchId - 1];
        }
        public void AddOrder(Order order)
        {
            Orders.Add(order);
        }
    }
}