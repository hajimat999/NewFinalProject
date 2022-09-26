using FinallyFinalProject.Models.Base;
using System.Collections.Generic;


namespace FinallyFinalProject.Models
{
    public class Product:BaseEntity
    {
        public string Model { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountPrice { get; set; }
        public int Rating { get; set; }
        public string Description { get; set; }
        public bool OnSale { get; set; }
        public bool InStock { get; set; }
        public List<ProductColor> ProductColors { get; set; }
        public int BrandId { get; set; }
        public Brand Brand { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public List<Comment> Comments { get; set; }
        public int InformationId { get; set; }
        public Information Information { get; set; }
        public int DiscountAmountId { get; set; }
        public DiscountAmount DiscountAmount { get; set; }
        public int OrderCount { get; set; }
        public List<ProductImage> ProductImages { get; set; }

    }
}
