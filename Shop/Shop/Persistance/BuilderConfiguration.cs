using Microsoft.EntityFrameworkCore;
using Shop.Models;

namespace Shop.Persistance;

public static class BuilderConfiguration
{
    public static void ApplyBuilderConfiguration(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Proizvod>(mb =>
        {

        });

        modelBuilder.Entity<Dobavljac>(mb =>
        {

        });

        modelBuilder.Entity<Proizvodjac>(mb =>
        {

        });
    }
}
