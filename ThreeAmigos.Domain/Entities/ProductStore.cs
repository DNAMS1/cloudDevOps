using System;

namespace ThreeAmigos.Domain.Entities
{
    public class ProductStore
    {
        public int IdProductStore { get; set; }
        public int IdProduct { get; set; }
        public DateTime CreatedAt { get; set; }
        public virtual Product Product { get; set; }
        
    }
}
