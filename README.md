# Asp.Net Core Web API With JWT Role Based Authorization Using Identity Framework

## Overview
This project is an ASP.NET Core Web API that demonstrates JWT Role-Based Authorization using the Identity Framework. It provides a secure and scalable way to manage user authentication and authorization in an ASP.NET Core application.

## Features
- User registration and login using JWT
- Role-based authorization
- Identity Framework integration
- Secure endpoints accessible only to users with specific roles

## Getting Started

### Prerequisites
- [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)

### Installation
1. Clone the repository:
   ```sh
   git clone https://github.com/minhcurus/apiwithroles.git
   cd apiwithroles
   ```
2. Update the database connection string in appsettings.json:
   ```sh
   "ConnectionStrings": {
    "DefaultConnection": "Server=YOUR_SERVER;Database=YOUR_DATABASE;Trusted_Connection=True;MultipleActiveResultSets=true"
    }
   ```
3.Apply the migrations and update the database:
   ```sh
   dotnet ef database update
   ```
4.Run the application:
   ```sh
   dotnet run
   ```

## Usage

### Register a new user
  Send a POST request to /api/auth/register with the following JSON payload:
   ```sh
   {
    "username": "yourusername",
    "password": "yourpassword",
    "email": "youremail@example.com"
   }
   ```

### Login
  Send a POST request to /api/auth/login with the following JSON payload:
   ```sh
   {
    "username": "yourusername",
    "password": "yourpassword"
   }
   ```

### Access protected endpoints
  Include the JWT token in the Authorization header of your requests:
   ```sh
   Authorization: Bearer YOUR_JWT_TOKEN
   ```

## Contributing
Contributions are welcome! Please submit a pull request or open an issue to discuss improvements or bug fixes.

## Contact
For any questions or feedback, please contact minhcurus.














