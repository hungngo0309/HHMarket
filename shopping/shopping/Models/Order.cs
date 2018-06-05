using System;
using System.Collections.Generic;

namespace shopping.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public String OrderDate { get; set; }
        public String OrderDeliveryDate { get; set; }
        public int statusOfDelivery { get; set; }
        public String Feedback { get; set; }
        public User userInfo { get; set; }
        public List<OrderDetail> orderDetailList { get; set; }
        public Order()
        {
        }
    }
}
