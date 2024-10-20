# CRUD API with .NET Core Web API and MongoDB

## Overview
This is a **CRUD (Create, Read, Update, Delete) API** built using **.NET Core Web API** and **MongoDB** as the database. The API is published using **IIS** and tested with **Postman** and **Swagger** for easy testing and documentation. It provides a robust, scalable solution for managing resources using RESTful services.

## Features

### General Features
- **Create, Read, Update, Delete (CRUD) Operations**:
  - Standard operations for managing data in a MongoDB database.
  - Supports multiple data types, including JSON objects.
  
### MongoDB Integration:
- Uses **MongoDB** as the database for efficient, flexible storage of document-based data.
- API endpoints interact with MongoDB collections, enabling data persistence and querying.

### Testing and Documentation:
- **Postman** is used for manual testing of API endpoints.
- **Swagger** is integrated for auto-generated API documentation and testing through a web interface.

### Deployment:
- The API is deployed and hosted using **IIS (Internet Information Services)** for easy access and management on Windows servers.

## Technology Stack

### Backend:
- **.NET Core Web API** for developing RESTful services.
- **MongoDB** as the NoSQL database for data storage.
- **C#** for business logic and handling API requests.

### Testing and Documentation:
- **Postman** for manual API testing.
- **Swagger** for API documentation and built-in testing via the Swagger UI.

### Deployment:
- **IIS** for deploying and hosting the API.

## Setup and Installation

1. Clone the repository.
2. Open the solution in Visual Studio.
3. Set up your **MongoDB** instance and configure the connection string in the `appsettings.json`.
4. Build and run the project locally to verify functionality.
5. Use **Postman** or **Swagger** to test the API endpoints.
6. Publish the API to **IIS** for deployment:
   - Use Visual Studio’s publishing tools to deploy the API to IIS.
   - Ensure the IIS server is correctly configured with your MongoDB connection string.

## Usage

1. **Create**: Add new resources via the API.
2. **Read**: Retrieve resources from the MongoDB database.
3. **Update**: Modify existing resources using their unique identifiers.
4. **Delete**: Remove resources from the database.
