using home2.Core.Repositories;
using home2.Core.Service;
using home2.Data.Repositories;
using home2.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home2.Serivce
{
        public class SellersService : ISellersService
    {
        private readonly ISellersRepository _sellersRepository;
            
        public SellersService(ISellersRepository SellersRepository)
        {
            _sellersRepository = SellersRepository;
        }

        public List<Seller> GetList()
        {
            return _sellersRepository.GetAll();

        }
        public Seller GetById(string id)
        {
            return _sellersRepository.GetById(id);

        }
        public void Post(Seller seller)
        {
            _sellersRepository.Post(seller);
        }
        public void Put(Seller seller)
        {
            _sellersRepository.Put(seller);

        }
        public void PutStatuse(string Id, bool IsActive)
        {
            _sellersRepository.PutStatus(Id, IsActive);
        }
    }

}
