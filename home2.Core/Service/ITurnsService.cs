using home2.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home2.Core.Service
{
    public interface ITurnsService
    {
        public List<Turn> GetList();
        public Turn GetById(string id);
        public void Post(Turn value);
        public void Put(Turn value);
        public void Delete(string id);
    }
}
