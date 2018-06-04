using System;
namespace shopping.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public String Name { get; set; }
        public String Description { get; set; }
        // 0: all, 1: men; 2: women; 3: kids;....
        public int Gender { get; set; }
        public int sellerID { get; set; }
        public String note { get; set; }
        public Product()
        {
        }
    }
}
