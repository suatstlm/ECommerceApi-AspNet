using Core.Persistence.Repositories;

namespace RentACar.Domain.Entities
{
    public class Customer : Entity
    {
        public Customer()
        {
        }

        public Customer(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public string Name { get; set; }
        public ICollection<Order> Orders { get; set; }
    }
}
