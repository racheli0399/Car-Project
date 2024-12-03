using home2.Entitis;
using Microsoft.EntityFrameworkCore;

namespace home2
{
    public class DataContext:DbContext
    {
        //internal IEnumerable<Customer> Customers;

        public DbSet<Customer> Customer { get; set; }
        public DbSet<Seller> Seller { get; set; }
        public DbSet<Turn> Turn { get; set; }

        //public DataContext()
        //{
        //    Customer = new List<Customer> 
        //    {new Customer { Id = "214870255", PhoneNumber = "0504115815", IsActive = true }, 
        //        new Customer { Id = "123456789", PhoneNumber = "0504115816", IsActive = false } };

        //    Seller = new List<Seller>
        //    { new Seller { Id = "214870277", YearsOfSeniority = 5, IsActive = true } , 
        //        new Seller { Id = "123456123", YearsOfSeniority = 4, IsActive = false } };

        //    Turn = new List<Turn> 
        //    { new Turn { Id = "241870256", Day = "27/6/2004", Hour = "16:45" },
        //        new Turn { Id = "123456789", Day = "15/10/2222", Hour = "17:00" } };

        //}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLocalDB;Database=home2");

        }
    }
}
