using home2.Core.Repositories;
using home2.Core.Service;
using home2.Data.Repositories;
using home2.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home2.Service
{
    public class CustomersService: ICustomersService
    {
        private readonly ICustomersRepository _CustomersRepository;
        public CustomersService(ICustomersRepository customersRepository)
        {
            _CustomersRepository = customersRepository;
        }

        public List<Customer> GetList()
        {
            return _CustomersRepository.GetAll();

        }
        public Customer GetById(string id)
        {
            return _CustomersRepository.GetById(id);

        }
        public void Add(Customer customer)
        {
            _CustomersRepository.Post(customer);
        }
        public void Put(Customer customer)
        {
             _CustomersRepository.Put(customer);

        }
        public void PutStatuse(string Id, bool IsActive)
        {
            _CustomersRepository.PutStatus(Id, IsActive);
        }
    }
}
