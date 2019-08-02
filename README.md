# The Bakery: C# MVC Wep App
### By Rochelle Roberts
-----

## Description
* Bakery website uses the MVC model to keep track of vendors and their purchases.

## Technologies Used
* C#
* .NET
* ASP.NET Core MVC
* HTML
* MSTest

## Installation and Run
* From the terminal, follow the steps below. 
* Click on the local host link (Ctrl + click )

```sh
$ git clone https://github.com/rochellev/TheBakery.MVC.Solution.git
$ cd .\TheBakery.MVC.Solution\Bakery
$ dotnet restore
$ dotnet run
```

## Specs

| Behaviors       | Input          | Output      |
| ---------------- |:------------:| :--------------:|
| home page welcomes users, has links | user navigates to website (local host, for now) | user will see splash page |
| user can create a new vendor by filling out a form | user fills out form | new vendor is added to static list of vendors |
| after adding a vendor, user routed back to home page to see list of vendors | completes form | sees list of vendors |
| click on vendor and see that vendors orders | user clicks on vendor's name | routed to the orders the vendor has |
| form for new order presented at vendors page | user goes to vendor page | form to add new order |
| user can create new orders for a given vendor | user completes form for new order | order added to vendor |
