using Microsoft.EntityFrameworkCore;

public class TaxiTripsContext : DbContext
{
    public DbSet<TaxiTrip> TaxiTrips { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Server=DESKTOP-HU0SJOH;Database=TaxiTrips;Trusted_Connection=True;TrustServerCertificate=True;");
    }
}