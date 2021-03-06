# Animal Shelter API

#### By **Amber Wilwand**

#### A program with a constructed API to help organize and manage animals in an animal shelter!

## Technologies Used

- C#
- NET 5.0
- dotnet
- MySQL
- Entity Framework
- Swashbuckle.AspNetCore

## Description

This is a C# and .NET API that lets you manage the cats and dogs available at an animal shelter!

## Setup/Installation Requirements

- Clone repository.
- Open code in your favorite text editor. I use VS Code.
- Using MySQL Workbench, import amber_wilwand.sql to create a local instance of the database.
- Create an appsettings.json file in the/AnimalShelter directory, and input the code { "ConnectionStrings": { "DefaultConnection": "Server=localhost;Port=3306;database=amber_wilwand;uid=root;pwd=[YOUR-PASSWORD];" } }
- Make sure to replace 'YOUR-PASSWORD' with your MySQL Workbench password!
- Head back into the program you're running the code with, and run the command dotnet build in the terminal.
- Now run the command dotnet run, and select localhost:5000 to interact with the schema via Swagger!

## API Documentation with Postman

- You can also use Postman or your browser to view and explore the API endpoints!

### Endpoints

Base URL: http://localhost:5001

HTTP Request structure

- GET /api/Animals
- POST /api/Animals
- GET /api/Animals/{id}
- PUT /api/Animals/{id}
- DELETE /api/Animals/{id}

Example query

- https://localhost:5001/api/animals/3

Example response

- {
  "animalId": 3,
  "name": "Honeybun",
  "species": "Cat",
  "age": "1 year",
  "gender": "Female"
  }

## Known Bugs

- None

## License

_Questions? Concerns? Contact me at 1234@internet.com_

Copyright (c) _10/23/2021_ _Amber Wilwand_
