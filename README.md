# ShipIt Inventory Management

## Setup Instructions
Open the project in VSCode.
VSCode should automatically set up and install everything you'll need apart from the database connection!

### Setting up the Database.
Create 2 new postgres databases - one for the main program (ShipIt )and one for our test database (ShipItTest).
Create a user with the following privaleges: can login, create databases, inherit rights from the parent roles.
Ask a team member for a dump of the production databases to create and populate your tables.

Then for each of the projects, add a `.env` file at the root of the project.
That file should contain a property named `POSTGRES_CONNECTION_STRING`.
It should look something like this:
```
POSTGRES_CONNECTION_STRING=Server=127.0.0.1;Port=5432;Database=your_database_name;User Id=your_database_user; Password=your_database_password;
```
To restore the database using the database dump run the following in pgAdmin:
psql -U postgres -d "DB name" -f "path to dump file"

Once Databases are created run the following commands, for both:

GRANT USAGE, SELECT ON SEQUENCE "gtin_p_id_seq" TO "role_name"

GRANT ALL PRIVILEGES ON SCHEMA public TO "role_name"

GRANT ALL PRIVILEGES ON ALL TABLES IN SCHEMA public TO "role_name" 

## Running The API
Once set up, simply run dotnet run in the ShipIt directory.

## Running The Tests
To run the tests you should be able to run dotnet test in the ShipItTests directory.

## Deploying to Production
TODO
