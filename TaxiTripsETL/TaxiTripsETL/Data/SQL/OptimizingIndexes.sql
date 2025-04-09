-- Index for fast lookup by PULocationID
CREATE NONCLUSTERED INDEX IX_TaxiTrips_PULocationID
ON TaxiTrips (PULocationID);

-- Index for fast calculation of the average TipAmount by PULocationID
CREATE NONCLUSTERED INDEX IX_TaxiTrips_PULocationID_TipAmount
ON TaxiTrips (PULocationID, TipAmount);

-- Index by trip distance — needed for sorting by longest trips
CREATE NONCLUSTERED INDEX IX_TaxiTrips_TripDistance
ON TaxiTrips (TripDistance DESC);

-- Adding a **computed persisted column** manually (without EF) for trip duration
ALTER TABLE TaxiTrips
ADD TripDurationMinutes AS DATEDIFF(MINUTE, PickupDateTime, DropoffDateTime) PERSISTED;

-- Index by duration
CREATE NONCLUSTERED INDEX IX_TaxiTrips_TripDurationMinutes
ON TaxiTrips (TripDurationMinutes DESC);
