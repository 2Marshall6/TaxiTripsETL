public class TaxiTripRaw
{
    public string VendorID { get; set; }
    public DateTime tpep_pickup_datetime { get; set; }
    public DateTime tpep_dropoff_datetime { get; set; }
    public int? passenger_count { get; set; }
    public decimal trip_distance { get; set; }
    public string RatecodeID { get; set; }
    public string store_and_fwd_flag { get; set; }
    public int PULocationID { get; set; }
    public int DOLocationID { get; set; }
    public string payment_type { get; set; }
    public decimal fare_amount { get; set; }
    public decimal extra { get; set; }
    public decimal mta_tax { get; set; }
    public decimal tip_amount { get; set; }
    public decimal tolls_amount { get; set; }
    public decimal improvement_surcharge { get; set; }
    public decimal total_amount { get; set; }
    public decimal congestion_surcharge { get; set; }
}