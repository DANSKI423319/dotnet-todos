# Dotnet - Todo API

This repository contains an example .NET API capturing CRUD functionality.

## Features
- [X] Create new todo items
- [X] Read all todo items
- [X] Read details of a specific todo item
- [X] Update existing todo items
- [X] Delete todo items
- [ ] Test suite

## Build Information

### Entity Framework Core 🦄
Entity Framework Core is a modern object-database mapper for .NET. It simplifies database interactions by allowing you to work with C# classes instead of writing raw SQL queries.

### ASP.NET Core 🌐
ASP.NET Core is a cross-platform, high-performance framework for building modern, cloud-based, and internet-connected applications. It provides features like routing, middleware support, and JSON handling.

### Swagger 📝
Swagger is used for API documentation and testing. It provides an interactive UI to explore and test API endpoints.

## Requirements

### .NET 8 SDK 🛠️
Ensure you have the .NET 8 SDK installed on your machine. The `global.json` file in the repository will ensure the correct SDK version is used.

Find installation information at the [official .NET website](https://dotnet.microsoft.com/).

### Docker Desktop 🐳
You'll need Docker on your machine, and the desktop app to go with it.

Find installation information at the [official website](https://www.docker.com/products/docker-desktop/).

## Getting Started
1. Clone the repository:
   ```bash
   git clone <repository-url>
   cd dotnet-todos
   ```

2. Setup the `appsettings.Development.json` file based on the `appsettings.Example.json`.

3. Start the docker container for the database:
   ```bash
   docker compose up -d
   ```

4. Run the application:
   ```bash
   dotnet run
   ```

5. Access the API at `http://localhost:XXXX` using the API client of your choice.