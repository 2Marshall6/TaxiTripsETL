CREATE TABLE TaxiTrips (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    PickupDateTime DATETIME2 NOT NULL,
    DropoffDateTime DATETIME2 NOT NULL,
    PassengerCount INT NULL,
    TripDistance DECIMAL(10, 2) NOT NULL,
    StoreAndFwdFlag NVARCHAR(50) NOT NULL,
    PULocationID INT NOT NULL,
    DOLocationID INT NOT NULL,
    FareAmount DECIMAL(10, 2) NOT NULL,
    TipAmount DECIMAL(10, 2) NOT NULL
);