using home2.Core.Repositories;
using home2.Core.Service;
using home2.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home2.Serivce
{
    public class TurnsService:ITurnsService
    {
        private readonly ITurnsRepository _turnsRepository;

        public TurnsService(ITurnsRepository turnsRepository)
        {
            _turnsRepository = turnsRepository;
        }

        public List<Turn> GetList()
        {
            return _turnsRepository.GetAll();
        }

        public Turn GetById(string id)
        {
            return _turnsRepository.GetById(id);
        }
         public void Post(Turn value)
        {
            _turnsRepository.Post(value);
        }
        public void Put(Turn value)
        {
            _turnsRepository.Put(value);
        }
        public void Delete(string id)
        {
            _turnsRepository.Delete(id);
        }


    }
}
