# Triangular-WebAPI

Welcome to Triangular-WebAPI, a powerful API for performing calculations and handling grid references with right triangles. This project provides a comprehensive set of endpoints to work with triangular calculations and grid references, making it easy to integrate into your own applications.

## Features

- Calculate grid references for right triangles
- Retrieve grid coordinates for triangle vertices
- Perform various calculations based on grid references and triangle properties

## Technologies Used

- ASP.NET Core Web API
- C#
- Entity Framework Core
- SQL Server
- Swagger UI

## Getting Started

To get started with Triangular-WebAPI, follow these steps:

### Prerequisites

- .NET Core SDK (version 7.0 or higher)
- SQL Server (Local or Azure)

### Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/killer6oose/Triangular-WebAPI.git
   ```

2. Navigate to the project directory:
   ```bash
   cd Triangular-WebAPI
   ```

3. Configure the database connection:
   - Update the connection string in `appsettings.json` with your SQL Server details.

4. Apply database migrations:
   ```bash
   dotnet ef database update
   ```

5. Start the application:
   ```bash
   dotnet run
   ```

6. Access the Swagger UI:
   - Open your web browser and navigate to `https://localhost:5001/swagger` to explore the available API endpoints.

## Usage

To use Triangular-WebAPI in your own projects, follow these steps:

1. Add a reference to the Triangular-WebAPI project in your solution.

2. Use the desired API endpoints for calculations and grid reference handling.

3. Ensure you have the necessary input data for the calculations, such as triangle vertices, grid dimensions, and cell size.

4. Make HTTP requests to the appropriate endpoints, passing the required data as per the API documentation.

5. Receive the calculated results or grid references in the API response and use them in your application as needed.

For detailed information on the available endpoints and request/response formats, refer to the Swagger documentation.

## Contributing

Contributions to Triangular-WebAPI are always welcome! If you have any ideas, suggestions, or bug reports, please submit an issue or a pull request.

## License

This project is licensed under the [MIT License](LICENSE).

```

Feel free to customize the above template to fit the specifics of the Triangular-WebAPI project. Add relevant sections, update technologies used, and provide any additional instructions or information as needed.
For detailed information on the available endpoints and request/response formats, refer to the Swagger documentation.
Contributing

Contributions to Triangular-WebAPI are always welcome! If you have any ideas, suggestions, or bug reports, please submit an issue or a pull request.
License

This project is licensed under the MIT License.
