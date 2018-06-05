using System;
namespace shopping.Models
{
    public class OrderDetail
    {
        public int OrderDetailId { get; set; }
        public int OrderId { get; set; }
        public ReviewComment reviewComment { get; set; }
        public int status { get; set; }
        public Product productionInfo;
        public int Quantity { get; set; }
        public ReviewComment reviewCommentInfo { get; set; }

        public OrderDetail()
        {
        }
    }
}
