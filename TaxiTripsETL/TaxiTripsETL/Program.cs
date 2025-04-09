class Program
{
    public static async Task Main(string[] args)
    {
        var filePath = "C:\\Users\\vitaliy\\source\\repos\\TaxiTripsETL\\sample-cab-data.csv";
        var taxiTripService = new TaxiTripService();
        await taxiTripService.ProcessCsvFileAsync(filePath);
    }
}