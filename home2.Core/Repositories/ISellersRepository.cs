using home2.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home2.Core.Repositories
{
        public interface ISellersRepository
        {
        public List<Seller> GetAll();
        public Seller GetById(string id);
        public void Post(Seller value);
        public void Put(Seller value);
        public void PutStatus(string Id, bool IsActive);
    }  
}

