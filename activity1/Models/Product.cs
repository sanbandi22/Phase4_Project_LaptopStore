﻿using System.ComponentModel.DataAnnotations;

namespace LaptopStoreProject.Models
{
    public class Product
    {
        public int productId { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int AvailableQuantity { get; set; }
        public string Image { get; set; }
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        [DataType(DataType.Date)]
        public DateTime ProductAddedDate { get; set; }
        public Category Category { get; set; }
        public Brand Brand { get; set; }
    }
}
