using BakedinHeaven.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BakedinHeaven1.Entities
{
    public class Item
    {
        [Key]
        public int ItemId { get; set; }
        [Required]
        public string ItemName { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public float WeightInGrams { get; set; }
        [Required]
        public float Kcal { get; set; }
        [Required]
        public bool IsVeg { get; set; }
        [Required]
        public bool IsSpecial { get; set; }
        [Required]
        public DateTime AvailableDate { get; set; }
        [Required]
        public string image { get; set; }





    }
}
    

