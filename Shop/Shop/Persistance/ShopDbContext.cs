using Microsoft.EntityFrameworkCore;
using Shop.Models;

namespace Shop.Persistance
{
    public class ShopDbContext : DbContext
    {
        public DbSet<Proizvod> Proizvodi { get; set; }

        public DbSet<Dobavljac> Dobavljaci { get; set; }

        public DbSet<Proizvodjac> Proizvodjaci { get; set; }
    }
}
