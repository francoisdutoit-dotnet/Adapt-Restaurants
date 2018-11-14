# Restaurants

Tech Stack:
-----------
ASP.Net Core Web App with Razor pages, EF Core, Sql Server and Bing Maps API

To Run:
-------
- Open the solution in Visual Studio and update the connection string in the apsettings.json file in the Adapt.Web project to your sql connection details.

- Build the solution and wait for all packages to download.

- Run the project from Visual Studio or publish to a desired environment.

Note: The project will take a bit longer on initial load as it will create and populate the database.

Known Issues:
-------------
- The Repository uses multiple queries to retrieve a dataset due to 
an issue with EF Core where we can't use "Include Filters"
 e.g The following will compile but will cause a runtime exception  
 ```
 .Include(t => t.RestuarantTime.Any(d=> d.Day == DateTime.Today.DayOfWeek))  
 ```
 For more detail see the [issue on github](https://github.com/zzzprojects/EntityFramework-Plus/issues/156).


sdfsdfsdfsdf
 
 

