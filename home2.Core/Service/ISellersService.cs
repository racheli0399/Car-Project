using home2.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home2.Core.Service
{
    public interface ISellersService
    {
        public List<Seller> GetList();
        public Seller GetById(string id);
        public void Post(Seller value);
        public void Put(Seller value);
        public void PutStatuse(string Id, bool IsActive);
    }
}
