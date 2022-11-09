using Core.Persistence.Repositories;

namespace ETradeApi.Domain.Entities
{
    public class Product : Entity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public float Price { get; set; }
        public ICollection<Order> Orders { get; set; }

        public Product()
        {
        }

        public Product(int id, string name, int stock, float price, DateTime createDate, DateTime updateDate): this()
        {
            Id = id;
            CreateDate = createDate;
            UpdateDate = updateDate;
            Name = name;
            Stock = stock;
            Price = price;
        }
    }
}
