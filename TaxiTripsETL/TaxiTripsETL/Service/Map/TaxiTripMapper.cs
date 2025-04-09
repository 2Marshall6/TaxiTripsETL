public class TaxiTripMapper
{
    public TaxiTrip MapToTaxiTrip(TaxiTripRaw raw)
    {
        return new TaxiTrip
        {
            PickupDateTime = TimeZoneInfo.ConvertTimeToUtc(raw.tpep_pickup_datetime, TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time")),
            DropoffDateTime = TimeZoneInfo.ConvertTimeToUtc(raw.tpep_dropoff_datetime, TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time")),
            PassengerCount = raw.passenger_count,
            TripDistance = raw.trip_distance,
            StoreAndFwdFlag = raw.store_and_fwd_flag == "Y" ? "Yes" : "No",
            PULocationID = raw.PULocationID,
            DOLocationID = raw.DOLocationID,
            FareAmount = raw.fare_amount,
            TipAmount = raw.tip_amount
        };
    }
}
