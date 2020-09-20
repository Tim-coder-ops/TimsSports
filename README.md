# TimsStore
 Student demo project based on Adam Freemans ASP.NET book.
 
 ## Create Solution and Projects
    dotnet new globaljson --sdk-version 3.1.302 --output TimsStoreSln/OutdoorProducts
    dotnet new web --no-https --output TimsStoreSln/OutdoorProducts --framework netcoreapp3.1
    dotnet new sln -o TimsStoreSln
    dotnet sln TimsStoreSln add TimsStoreSln/OutdoorProducts 
    dotnet new xunit -o TimsStoreSln/OutdoorProducts.Tests --framework netcoreapp3.1
    dotnet sln TimsStoreSln add TimsStoreSln/OutdoorProducts.Tests 
    dotnet add TimsStoreSln/OutdoorProducts.Tests reference TimsStoreSln/OutdoorProducts 

## Progreess Check #1
![check 1](https://github.com/Tim-coder-ops/TimsSports/blob/master/Screen%20Captures/Welcome%20Screen.PNG)

## Progress Check #2
![check 2](https://github.com/Tim-coder-ops/TimsSports/blob/master/Screen%20Captures/Bootstrap%20Capture.PNG)

### Questions:
* What is Entity Framework?
  * Entity Framework is an object-relational mapper (O/RM) that enables .NET developers to work with a database using .NET objects. It eliminates the need for most of the data-access code that developers usually need to write.
* What is a Connection String?
  * Connection strings used by the Entity Framework contain information used to connect to the underlying ADO.NET data provider. They contain the neccessary information about the required model and mapping files.
* What is a Database Context?
  * DbContext is the primary class that is responsible for interacting with the database. It is responsible for the following activities: Querying, Change Tracking, Persisting Data, Caching, Manage Relationship and Object Materialization.
* What is a Model Repository?
  * The Model repository is a relational database that stores the metadata for projects and folders.
* Migration vs Scaffolding?
  * Scaffolding is the automatic creation of CRUD operations while Migration is reflecting changes in the database to the models
* Seeding the database?
  * Seeding a database is providing the intial data to a database

# Chapter 8:

## Figure 8-5
![8-5](https://github.com/Tim-coder-ops/TimsSports/blob/master/Screen%20Captures/Fig%208-5.PNG) 
## Figure 8-10
![8-10](https://github.com/Tim-coder-ops/TimsSports/blob/master/Screen%20Captures/Fig%208-10.PNG) 
## Figure 8-11
![8-11](https://github.com/Tim-coder-ops/TimsSports/blob/master/Screen%20Captures/Fig%208-11.PNG) 
## Tests
![tests](https://github.com/Tim-coder-ops/TimsSports/blob/master/Screen%20Captures/Tests%201.PNG) 
