using System;
namespace shopping.Models
{
    public class OrderDetail
    {
        public int IdOrderDetail { get; set; }
        public int IdOrder { get; set; }
        public OrderDetail()
        {
        }
    }
}
