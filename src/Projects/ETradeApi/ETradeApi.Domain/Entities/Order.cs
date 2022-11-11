using Core.Persistence.Repositories;

namespace ETradeApi.Domain.Entities
{
    public class Order : Entity
    {
        public string Description { get; set; }
        public string Address { get; set; }
        public ICollection<Product> Products { get; set; }
        public Customer Customer { get; set; }

        public Order()
        {
        }

        public Order(int id, string description, string address, DateTime createDate, DateTime updateDate): this()
        {
            Id = id;
            CreateDate = createDate;
            UpdateDate = updateDate;
            Description = description;
            Address = address;
        }
    }
}
