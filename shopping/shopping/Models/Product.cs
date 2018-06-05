using System;
namespace shopping.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public  string Name { get; set; }
        public string Description { get; set; }
        // 0: all, 1: men; 2: women; 3: kids;....
        public int Gender { get; set; }
        public User sellerInfo { get; set; }
        public string note { get; set; }
        public Category CategoryInfo { get; set; }
        public int Total { get; set; }
        public int RemainQuantity { get; set; }
        public Product()
        {
        }
    }
}
