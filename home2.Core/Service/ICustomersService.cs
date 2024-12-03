using home2.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home2.Core.Service
{
    public interface ICustomersService
    {
        public List<Customer> GetList();
        public Customer GetById(string Id);
        public void Put(Customer customer);
        public void Add(Customer customer);
        public void PutStatuse(string Id, bool IsActive);



    }
}
