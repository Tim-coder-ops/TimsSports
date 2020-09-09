# TimsStore
 Student demo project based on Adam Freemans ASP.NET book.
 
 ## Create Solution and Projects
    dotnet new globaljson --sdk-version 3.1.401 --output TimsStoreSln/OutdoorProducts
    dotnet new web --no-https --output TimsStoreSln/OutdoorProducts --framework netcoreapp3.1
    dotnet new sln -o TimsStoreSln
    dotnet sln TimsStoreSln add TimsStoreSln/OutdoorProducts 
    dotnet new xunit -o TimsStoreSln/OutdoorProducts.Tests --framework netcoreapp3.1
    dotnet sln TimsStoreSln add TimsStoreSln/OutdoorProducts.Tests 
    dotnet add TimsStoreSln/OutdoorProducts.Tests reference TimsStoreSln/OutdoorProducts 
