using Microsoft.EntityFrameworkCore;

public class TaxiTripRepository
{
    private readonly TaxiTripsContext _context;

    public TaxiTripRepository()
    {
        _context = new TaxiTripsContext();
    }
    public async Task BulkInsertTripsAsync(List<TaxiTrip> trips)
    {
        if (trips == null || trips.Count == 0)
            return;

        await _context.TaxiTrips.AddRangeAsync(trips);
        await _context.SaveChangesAsync();
    }
}