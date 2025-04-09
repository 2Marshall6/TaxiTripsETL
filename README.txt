Taxi Trip Data Processing Project (ETL)
This project implements a solution for processing and loading taxi trip data from a CSV file into a SQL Server database using C#.

Features
Processing large CSV files.

Data transformation (e.g., converting time zones to UTC).

Duplicate filtering and saving them into a separate file.

Inserting data into a database using Entity Framework Core.

Technologies Used
C#

Entity Framework Core

SQL Server

CsvHelper

Setup
Clone the repository.

Configure the database connection string in the TaxiTripsContext class.

Run the application to process the CSV file.

Features
The project does not use DI containers or complex architecture, as it is intended for simple ETL tasks with a focus on performance when processing large files.