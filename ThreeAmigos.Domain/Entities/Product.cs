using System;
using System.Collections.Generic;

namespace ThreeAmigos.Domain.Entities
{
    public class Product
    {
        
        public int CategoryId { get; set; }
        public int BrandId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int StockLevel { get; set; }
        public bool Active { get; set; }

        public Category Category { get; set; }
        public Brand Brand { get; set; }
        public virtual ICollection<ProductStore> StoreProduct { get; set; }
        public int IdProduct { get; set; }
     
    }
}
