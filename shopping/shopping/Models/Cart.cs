using System;
namespace shopping.Models
{
    public class Cart
    {
        public int UserId { get; set; }

        public Product productInfo { get; set; }
        public int Quantity { get; set; }
        public string AddDate { get; set; }
        // status 0: in card, 1: ordered, 2: wishlist
        public int status { get; set; }
        public Cart()
        {
        }
    }
}
