# dotnet-ef CLI

## Install 

dotnet tool install --global dotnet-ef

## Migrate data model

dotnet ef migrations add InitialCreate

EF Core will create a folder named Migrations in your project directory containing two files with the code that represents the database migrations.

## Create database and schema

dotnet ef database update