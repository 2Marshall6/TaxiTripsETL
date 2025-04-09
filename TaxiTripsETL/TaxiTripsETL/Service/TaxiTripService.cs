using System.Data;
using System.Globalization;
using CsvHelper;

public class TaxiTripService
{
    private readonly TaxiTripRepository _repository;
    private readonly TaxiTripMapper _mapper;

    public TaxiTripService()
    {
        _repository = new TaxiTripRepository();
        _mapper = new TaxiTripMapper(); 
    }

    /// <summary>
    /// To handle large files (e.g., 10 GB), it's better not to load all the data into memory at once. You should use streaming to process
    /// the file in chunks. It's also important to use batch inserts into the database for performance optimization. This will reduce memory
    /// usage and speed up the processing.
    /// </summary>
    public async Task ProcessCsvFileAsync(string filePath)
    {
        var rawTrips = ReadRawTrips(filePath);
        var (uniqueTrips, duplicates) = FilterAndTransform(rawTrips);
        await SaveDuplicatesAsync(duplicates);
        _repository.BulkInsertTripsAsync(uniqueTrips);
    }

    private List<TaxiTripRaw> ReadRawTrips(string filePath)
    {
        using var reader = new StreamReader(filePath);
        using var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
        csv.Context.RegisterClassMap<TaxiTripRawMap>();
        return csv.GetRecords<TaxiTripRaw>().ToList();
    }

    private (List<TaxiTrip> unique, List<TaxiTrip> duplicates) FilterAndTransform(List<TaxiTripRaw> rawList)
    {
        var seenKeys = new HashSet<string>();
        var unique = new List<TaxiTrip>();
        var duplicates = new List<TaxiTrip>();

        foreach (var raw in rawList)
        {
            var entity = _mapper.MapToTaxiTrip(raw);

            var key = $"{entity.PickupDateTime}_{entity.DropoffDateTime}_{entity.PassengerCount}";

            if (seenKeys.Contains(key))
                duplicates.Add(entity);
            else
            {
                seenKeys.Add(key);
                unique.Add(entity);
            }
        }

        return (unique, duplicates);
    }

    private async Task SaveDuplicatesAsync(List<TaxiTrip> duplicates)
    {
        if (!duplicates.Any()) return;

        using var writer = new StreamWriter("duplicates.csv");
        using var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
        await csv.WriteRecordsAsync(duplicates);
    }
}
