# BakeryShop.Solution
#### Created By: Connor Burgess 
* * *
<p align="center"><img src="" alt="Bakery Shop"
	title="Bakery Shop" width="350" height="200"></p>

## Description  
Project creates a bakery shop splash page with list of flavor categories and treats with full CRUD functionality. Utilizes .Net Core 5.0 / ASP.NET Core MVC and follows RESTful practices. Relational data is manipulated using ORM through Entity Framework Core in order to abstract and simplify SQL interaction. User authentication provided through ASP.NET Core Identity.
* * *

## Technologies used
* C#
* .Net Core v5.0
* Entity Framework Core
* ASP.NET Core MVC
* ASP.NET Core Identity
* Tailwind
* PostCSS
* MySQL
* MySQL Workbench
* RESTful Routing

* * *
## Setup 1) Initial Setup
* Ensure .Net v5.0 Core is installed: [download here](https://dotnet.microsoft.com/download/dotnet/5.0)
* Ensure dotnet script is installed: [instructions here](https://github.com/filipw/dotnet-script)
* Clone Repo from GitHub (Link: https://github.com/ConnorBurgess/BakeryShop.Solution)

## Setup 2) Initial Database Setup
* Ensure MySQL is installed [download here](https://www.mysql.com/)
* Ensure MySQL Workbench is installed [download here](https://www.mysql.com/products/workbench/)

## Setup 3) Install Tailwind
* Navigate to ./BakeryShop.Solution/BakeryShop and type $"npm install" (no bling / quotes) in terminal in order to install dependencies.
* Navigate to ./BakeryShop.Solution/BakeryShop and type $"npx tailwind build ./wwwroot/css/site.css -o ./wwwroot/css/output.css" (no bling / quotes) in terminal in order to build CSS.

## Setup 4) Create appsettings.json
* In root directory of project create a file called "appsettings.json"
* Copy and paste the following into the file:
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;database=connor_burgess;uid={YOUR UID};pwd={YOUR PWD;"
  }
}
* Input your UID and password from MYSQL database setup and remove curly braces from around pwd/UID. Please note your port may be different.
* If planning to push a project to GitHub, it is advised to avoid revealing sensitive details by [setting up a .gitignore](https://docs.github.com/en/github/using-git/ignoring-files) and ignoring this file.

## Setup 5) Dotnet Setup & Running Program
* Navigate to ./BakeryShop.Solution/BakeryShop inside of the cloned repo and type $"dotnet restore" (no bling / quotes) in terminal
* * From inside ./BakeryShop.Solution/BakeryShop folder type $"dotnet ef database update" (no bling / quotes) in terminal in order to connect migrations to MYSql
* You may utilize MySQL Workbench in order to verify database files if desired. [Check out the MySQL docs](https://dev.mysql.com/doc/workbench/en/wb-sql-editor-navigator.html)
* Run program by inputting$"dotnet run" (no bling / quotes) in terminal while in ./BakeryShop.Solution/BakeryShop folder.

* * *

## To Do:

## Resources Used:
* Sidebar Navigation - https://tailwindcomponents.com/component/sidebar-navigation
* Sign up form - https://tailwindcomponents.com/component/sign-up-form-1
## Additional comments:
* Created on 3/26/21  
* * *

## License:
> *&copy; Connor Burgess, 2021*

Licensed under [MIT license](https://mit-license.org/)

* * *

## Contact Information
_Connor Burgess: [Email](connorburgesscodes@gmail.com)_