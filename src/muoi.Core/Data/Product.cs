using Abp.Domain.Entities;
using System;

namespace muoi.Core.Data
{
    public class Product:Entity
    {
       // public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal OriginalPrice { get; set; }
        public int Stock { get; set; }
        public int ViewCount { get; set; }
        public DateTime DateCreated { get; set; }
        public bool? IsFeatured { get; set; }
        public string Decription { get; set; }
       

    }
}
