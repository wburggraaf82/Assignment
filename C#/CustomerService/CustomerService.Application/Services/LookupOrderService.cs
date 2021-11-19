using CustomerService.Domain.Models;
using CustomerService.Persitence;

namespace CustomerService.Application.Services
{
    public class LookupOrderService //Should we use an Interface here?
    {
        private Repository<Order> _repository;

        public LookupOrderService() //Should we work with interfaces here?
        {
            _repository = new Repository<Order>();
        }

        public void Invoke(int orderNumber)
        {
            //_repository.List().Search for the order by number.
        }
    }
}
