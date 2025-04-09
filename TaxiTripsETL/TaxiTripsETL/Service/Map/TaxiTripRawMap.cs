using CsvHelper.Configuration;

public class TaxiTripRawMap : ClassMap<TaxiTripRaw>
{
    public TaxiTripRawMap()
    {
        Map(m => m.VendorID).Name("VendorID");
        Map(m => m.tpep_pickup_datetime).Name("tpep_pickup_datetime");
        Map(m => m.tpep_dropoff_datetime).Name("tpep_dropoff_datetime");
        Map(m => m.passenger_count).Name("passenger_count");
        Map(m => m.trip_distance).Name("trip_distance");
        Map(m => m.RatecodeID).Name("RatecodeID");
        Map(m => m.store_and_fwd_flag).Name("store_and_fwd_flag");
        Map(m => m.PULocationID).Name("PULocationID");
        Map(m => m.DOLocationID).Name("DOLocationID");
        Map(m => m.payment_type).Name("payment_type");
        Map(m => m.fare_amount).Name("fare_amount");
        Map(m => m.extra).Name("extra");
        Map(m => m.mta_tax).Name("mta_tax");
        Map(m => m.tip_amount).Name("tip_amount");
        Map(m => m.tolls_amount).Name("tolls_amount");
        Map(m => m.improvement_surcharge).Name("improvement_surcharge");
        Map(m => m.total_amount).Name("total_amount");
        Map(m => m.congestion_surcharge).Name("congestion_surcharge");
    }
}
