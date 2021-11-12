# dotnet CLI

## tldr;

dotnet new web -o PizzaStore
dotnet add package Swashbuckle.AspNetCore --version 6.1.4

To view Swagger API
https://localhost:7098/swagger/index.html

## Create new project

PS> dotnet new web -o PizzaStore
The template "ASP.NET Core Empty" was created successfully.

Processing post-creation actions...
Running 'dotnet restore' on D:\src\github\learnMinimalApi\PizzaStore\PizzaStore.csproj...
  Determining projects to restore...
  Restored D:\src\github\learnMinimalApi\PizzaStore\PizzaStore.csproj (in 83 ms).
Restore succeeded.

## Add Swagger

dotnet add package Swashbuckle.AspNetCore --version 6.1.4