using Core.Persistence.Repositories;

namespace ETradeApi.Domain.Entities
{
    public class Customer : Entity
    {
        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; }

        public Customer()
        {
        }

        public Customer(int id, string name, DateTime createDate, DateTime updateDate) : this()
        {
            Id = id;
            CreateDate = createDate;
            UpdateDate = updateDate;
            Name = name;
        }
    }
}
