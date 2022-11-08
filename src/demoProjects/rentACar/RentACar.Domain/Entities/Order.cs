using Core.Persistence.Repositories;

namespace RentACar.Domain.Entities
{
    public class Order : Entity
    {
        public Order()
        {
        }

        public Order(int id, string description, string address, Customer customer): this()
        {
            Id = id;
            Description = description;
            Address = address;
            Customer = customer;
        }

        public string Description { get; set; }
        public string Address { get; set; }
        public ICollection<Product> Products { get; set; }
        public Customer Customer { get; set; }


    }
}
