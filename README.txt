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









