using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using System;

namespace muoi.Product.Dtos
{
    [AutoMapFrom(typeof(muoi.Core.Data.Product))]
   public class ProductDto:EntityDto
    {
        //public int Id { get; set; }
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
