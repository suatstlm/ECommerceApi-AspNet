using Core.Persistence.Repositories;

namespace RentACar.Domain.Entities
{
    public class Product : Entity
    {
        public Product()
        {
        }

        public Product(int id, string name, int stock, float price) : this()
        {
            Id = id;
            Name = name;
            Stock = stock;
            Price = price;
        }

        public string Name { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
