using BakedinHeaven.DataAccess.Entities;
using BakedinHeaven1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BakedinHeaven.BusinessService.Dtos
{
    public class OrderDto
    {
        public int OrderId { get; set; }
        public int ItemId { get; set; }
        public Item Item { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public DateTime OrderDate { get; set; }

    }
}
