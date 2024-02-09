# Eau Claire's Hair Salon

## An MVC web application to manage a hair salon employees and their clients

### By Monica Barboza

## Technologies Used

* C#
* ASP.NET
* MS TEST
* Bootstrap
* MySQL
* MySWL Workbench
* EF Core
* ASP Core MVC MSBuild

## Description

How to Use:

Stylist Management:

* Add new stylists by providing their name and specialties.
* Edit existing stylist details as needed.

Client Management:

* Add clients with their names, notes, and link them to specific stylists.Update client information as preferences or details change.

Search Function:

* Use the search bar to quickly find clients based on keywords.
* Enhance customer service by retrieving relevant information efficiently.

Notes Section:

* Leave and view notes for each client to personalize their salon experience.

This salon management application is tailored to meet the unique needs of salon owners, providing a comprehensive solution for effective stylist and client management. Stay organized, enhance customer satisfaction, and elevate your salon operations with our user-friendly platform.

## Setup/Installation Requirements

This Project assumes you have MySql Server and Workbench  installed if you do not have them installed follow along with these lessons at
[Learn how to program](https://full-time.learnhowtoprogram.com/c-and-net/getting-started-with-c/installing-and-configuring-mysql).

1. Open terminal or command prompt.
2. Clone the repository by running the following command to your desktop:

    ```bash
    git clone https://github.com/MonBoza/HairSalon.Solution.git
     ```

3. Open the project in your favorite code editor.

4. Navigate to the production directory "HairSalon" and run the follow commands in your terminal to add the following dependencies

    ```bash
    dotnet add package Microsoft.EntityFrameworkCore -v 6.0.0
    ```

    ```bash
    dotnet add package Pomelo.EntityFrameworkCore.MySql -v 6.0.0
    ```

5. Within the production directory `HairSalon`, create new file called `appsettings.json`

6. Make sure appsettings.json is added to the .gitignore file and it is added to the repository before pushing with your personal information.

7. Within `appsettings.json`, put in the following code replacing the `uid` and the `pwd` values with your own username and password for MySQL.

    ```bash
    {
      "ConnectionStrings": {
        "DefaultConnection": "Server=localhost;Port=3306;database=monica_barboza;uid=[YOUR-USER-HERE];pwd=[YOUR-PASSWORD-HERE];"
      }
    }
    ```

8. Run

    ```bash
    dotnet watch run
    ```
  
in your terminal.

## To set up Database

To run this application you need to import the `monica_barboza.sql` file located in the top of the repository to MySQL Workbench.

1. In the MySql Workbench select Navigator > Administration window, select `Data Import/Restore`.

2. In `Import Options` select `Import` from `Self-Contained File`.

3. Navigate to the monica_barboza.sql file.

4. Under `Default Schema` to be `Imported to`, Select the `New` button
    * Enter the name of your database "monica_barboza"
    * Click OK

5. Navigate to the tab called Import Progress and click Start Import at the bottom right corner of the window.

6. After you are finished with the above steps, reopen the `Navigator > Schemas` tab. Right click and select `Refresh All`.

## Known Bugs

* No Known bugs
  * If bugs are discovered please contact the author

## License

Copyright 2024 MONICA BARBOZA

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the “Software”), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

Email: (mailto:<MonBoza@gmail.com>)

Copyright (c) February 02, 2024 Monica Barboza

### SQL Schema Diagram

<img src="image.png" alt="Schema Diagram" width="500px" />
