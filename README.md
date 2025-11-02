# .NET Applications - Pizza API & File Directory App by Andrew Mogbeyiromore

This solution contains two .NET 9.0 projects demonstrating core .NET development concepts: RESTful web APIs with ASP.NET Core and file system operations in C#.

## Projects

### PizzaApi
A RESTful web API built with ASP.NET Core that implements CRUD (Create, Read, Update, Delete) operations for pizza management. The API uses controller-based architecture and provides endpoints for managing pizza data.

### FileDirectoryApp
A console application that demonstrates file and directory manipulation in .NET, including reading sales data from JSON files and generating formatted sales summary reports.

## Requirements

- .NET SDK 9.0 or higher
- A code editor (Visual Studio, VS Code, or Rider recommended)

## Getting Started

### Clone the Repository
```bash
git clone <repository-url>
cd pizzas
```

### Restore Dependencies
```bash
dotnet restore
```

## Running the Projects

### PizzaApi (Web API)

1. Navigate to the PizzaApi directory:
   ```bash
   cd PizzaApi
   ```

2. Run the application:
   ```bash
   dotnet run
   ```

3. The API will be available at:
   - **HTTP**: `http://localhost:5000`
   - **Swagger UI**: `http://localhost:5000/swagger`
   - **API Endpoint**: `http://localhost:5000/api/pizza`

### FileDirectoryApp (Console Application)

1. Navigate to the FileDirectoryApp directory:
   ```bash
   cd FileDirectoryApp
   ```

2. Run the application:
   ```bash
   dotnet run
   ```

   The application will:
   - Create sample sales files in `stores/201/`
   - Generate a sales summary report (`sales-summary.txt`)

## API Endpoints

### GET /api/pizza
Returns a list of all pizzas.

**Response**: Array of pizza objects

### GET /api/pizza/{id}
Returns a specific pizza by ID.

**Response**: Pizza object

### POST /api/pizza
Creates a new pizza.

**Request Body**: JSON object with `name` and `isGlutenFree` properties

### PUT /api/pizza/{id}
Updates an existing pizza.

**Request Body**: JSON object with `id`, `name`, and `isGlutenFree` properties

### DELETE /api/pizza/{id}
Deletes a pizza by ID.


## Features

- **PizzaApi**: RESTful API with full CRUD operations, Swagger documentation, and in-memory data storage
- **FileDirectoryApp**: File system operations, JSON parsing, and formatted report generation with currency formatting

## Technologies Used

- **.NET 9.0**
- **ASP.NET Core** (Web API)
- **Swashbuckle.AspNetCore** (Swagger/OpenAPI documentation)
- **C#** with modern language features

## License

This project is for educational purposes.

