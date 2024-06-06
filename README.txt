2024-05-15
Haidir Magribi
ISO Format
1310 EDT

1315
Added a HelloWorld Controller
Created Welcome method

1320
Changed the Welcome method to include two parameters.

1324
Modified Welcome method with Name and ID.

1331
Modified Index method in HelloWorldController

1334
Created Index.cshtml and getting eror

1346
Created HelloWorld folder inside Views

1347
Created Index.cshtml inside HelloWorld folder inside Views

1454
Changed the Title inside _Layout.cshtml

1456
Changed the Navbar Brand Title inside _Layout.cshtml

1457
Changed the footer inside _Layout.cshtml

1500
Changed HelloWord Index view

TIME 2 HOURS

2024-05-23

1301
Continue Passing Data from the Controller to the View

1306
Create a Welcome view template named Views/HelloWorld/Welcome.cshtml
Custom title and make 'for' iteration for showing the parameters data.
can be access in url: https://localhost:7031/HelloWorld/Welcome/3?name=Rick

1310
Add Class Name the file Movie.cs inside Models folder

1311
Update the Models Movie.cs
The Movie class contains an Id field, which is required by the database for the primary key.
The DataType attribute on ReleaseDate specifies the type of the data (Date).
With this attribute:
    The user isn't required to enter time information in the date field.
    Only the date is displayed, not time information.

1317
Add NuGet packages
Use the scaffolding tool to produce Create, Read, Update, and Delete (CRUD) pages for the movie model.

1321
Initial migration
Running command in NuGet Package Manager Console:
Add-Migration InitialCreate
Update-Database
It created 20240523172119_InitialCreate.cs file

1425
Created SeedData class to add First 5 movies data to database.

1430
Add the seed initializer in Program.cs
using MvcMovie.Models;

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;

    SeedData.Initialize(services);
}


1440
Custom Releasedate column name:
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Display(Name = "Release Date")]
[Column(TypeName = "decimal(18, 2)")]

TIME 2 HOURS

2024-05-30

1310 EDT

Add search capability to the Index action method that lets me search movies by genre or name
with the following code in index method in MovieController:
var movies = from m in _context.Movie
             select m;

1320
add the <form> for search in view index

1329 
Updated the Index method found inside Controllers/MovieController.cs with the new code.

1333
Confirmed that movies can be searched using the string at https://localhost:7031/Movies/Index?searchString=C, and it works perfectly fine.

1336
After updating the index method with an id, confirmed that the search title can now be passed as route data instead of as a query string value at https://localhost:7031/Movies/index/one.

1339
Filtered 'movies' based on the 'searchString' and returned the filtered results asynchronously in the 'Index' action method.

1344
Added a <form> to the Views/Movies/Index.cshtml file, allowing users to input a string and submit it to the 'Index' action of the 'Movies' controller, triggering the filtering logic in the 'Index' method to display only movies matching the search criteria.

1355
Successfully ran the project and confirmed that the Title, Movie Search box, and filter button are visible. Entered a movie name that is in the database, and it successfully displayed it.

1358
Added HttpPost Index method to the MovieController.cs file and tested the method in the web browser.

1401
Added HTTP GET in Views/Movies/Index.cshtml file to fix capturing the search information to the bookmark for sharing with others.

1405
Created a new MovieGenreViewModel class in the Models folder, containing a list of movies, SelectList, MovieGenre, and SearchString.

1413
Replaced the Index method in MovieController.cs with the new code. Tested the code by running the web application, and it works.

1419
Took a break.

1427
Added a search by genre feature to the Index view by updating Index.cshtml file found in Views/Movies/. The form now includes a dropdown for filtering movies by genre and a textbox for filtering by title, enabling combined filtering when submitting the form to the 'Index' action.

1434
Tested the app by searching by genre, by movie title, and by both in the web browser, and it works.

1435
Added the Rating property to the movie model by editing Models/Movie.cs. Also added the Rating property in MovieController.cs. Edited Index.cshtml to include the new rating field.

Time 1 Hour 30 Minutes

2024-06-06
1309
Updated the /Views/Movies/Create.cshtml with a Rating field.

1325
Migrated the rating database and updated the database

1326
Validated Error UI: "Its works"

1331
Examined the Details and Delete methods
"Everything is Great"

1338
Configurated github,
commit and push

Finish

Time 30 Minutes

Total time: 4 Hours









