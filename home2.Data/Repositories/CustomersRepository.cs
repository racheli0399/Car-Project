using home2.Core.Repositories;
using home2.Core.Service;
using home2.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home2.Data.Repositories
{
    public class CustomersRepository: ICustomersRepository
    {
        private readonly DataContext _context;
        public CustomersRepository(DataContext context)
        {
            _context = context;
        }
        public List<Customer> GetAll()
        {
            return _context.Customer.ToList();
        }
        public Customer GetById(string id)
        {
            return _context.Customer.ToList().Find(x => x.Id == id);
        }
        public void Post( Customer value)
        {
            _context.Customer.Add(new Customer { Id = value.Id, PhoneNumber = value.PhoneNumber, IsActive = value.IsActive });
        }
        public void Put(Customer value)
        {
            var customer = _context.Customer.ToList().Find(e => e.Id ==value.Id);
            customer.Id = value.Id;
            customer.PhoneNumber = value.PhoneNumber;
            customer.IsActive = value.IsActive;
            customer.YearsOfSeniority = value.YearsOfSeniority;
        }
        public void PutStatus(string Id, bool IsActive)
        {
            var customer = _context.Customer.ToList().Find(e => e.Id == Id);
            customer.IsActive = IsActive;
        }

    }
}
