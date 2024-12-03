using home2.Core.Repositories;
using home2.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static home2.Core.Repositories.ISellersRepository;

namespace home2.Data.Repositories
{
    public class SellersRepository : ISellersRepository
    {
        private readonly DataContext _context;
        public SellersRepository(DataContext context)
        {
            _context = context;
        }
        public List<Seller> GetAll()
        {
            return _context.Seller.ToList();
        }

        public Seller GetById(string id)
        {
           return _context.Seller.ToList().Find(x => x.Id == id);
        }

        public void Post(Seller value)
        {
            _context.Seller.ToList().Add(new Seller { Id = value.Id, YearsOfSeniority = value.YearsOfSeniority, IsActive = value.IsActive });
        }
        public void Put(Seller value)
        {
            var Seller = _context.Seller.ToList().Find(e => e.Id == value.Id);
            Seller.Id = value.Id;
            Seller.YearsOfSeniority = value.YearsOfSeniority;
            Seller.IsActive = value.IsActive;
            
        }
        public void PutStatus(string Id, bool IsActive)
        {
            var Seller = _context.Seller.ToList().Find(e => e.Id == Id);
            Seller.IsActive = IsActive;
        }

    }
}
