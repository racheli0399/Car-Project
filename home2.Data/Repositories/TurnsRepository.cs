using home2.Core.Repositories;
using home2.Entitis;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace home2.Data.Repositories
{
    public class TurnsRepository : ITurnsRepository
    {
        private readonly DataContext _context;

        public TurnsRepository(DataContext context)
        {
            _context = context;
        }
        public List<Turn> GetAll()
        {
            return _context.Turn.ToList();
        }
         public Turn GetById(string Id)
        {
            return _context.Turn.ToList().Find(x => x.Id == Id);
        }

        public void Post (Turn value)
        {
            _context.Turn.Add(new Turn { Id = value.Id, Day = value.Day, Hour = value.Hour });
        }
        public void Put(Turn value)
        {
            var turn = _context.Turn.ToList().Find(e => e.Id == value.Id);
            turn.Id = value.Id;
            turn.Day = value.Day;
            turn.Hour = value.Hour;
        }
        public void Delete(string id)
        {
            var index = _context.Turn.ToList().FindIndex(e => e.Id == id);
           
                _context.Turn.ToList().RemoveAt(index);
            
        }





    }
}
