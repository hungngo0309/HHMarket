using System;
using System.Collections.Generic;

namespace shopping.Models
{
    public class Order
    {
        public int OrderID { get; set; }
        public String OrderDate { get; set; }
        public String OrderDeliveryDate { get; set; }
        public Enum OrderStatus { get; set; }
        public String note { get; set; }
        public List<OrderDetail> orderDetailList { get; set; }
        public Order()

        {
        }
    }
}
