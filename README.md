# ASP.NET WebAPI with DTO Design Pattern
This project showcases the implementation of a WebAPI using ASP.NET and C#, incorporating the DTO (Data Transfer Object) design pattern. The solution can be downloaded and connected to a database to run the application (don't forget to modify the connection string accordingly).

# Project Structure
The project follows a layered architecture, consisting of the following components:

# BL (Business Logic):
This layer handles the business logic of the application.
# DAL (Data Access Layer):
This layer is responsible for interacting with the database.
Usage
To interact with the API, you can use your preferred tool, such as Postman, or access it through the integrated Swagger app provided within the solution.

The API offers two login endpoints:

# Staticlogin (not recommended):
This endpoint uses hardcoded username and password for authentication.
# Login:
This endpoint connects to the database for authentication.
Based on the user's role, the API provides different levels of access:

A user with the "Employee" role can update and view department information.
A user with the "Manager" role has access to all department data and the ability to delete departments.
# Getting Started
To get started with this project, follow these steps:

Clone the repository to your local machine.
Set up the necessary dependencies and ensure the proper environment is configured (details provided in the project documentation).
Connect the solution to a compatible database by modifying the connection string accordingly.
Run the application locally or deploy it to a web server.
Access the API through your preferred tool or via the integrated Swagger app.
For more detailed instructions and documentation, please refer to the project's wiki or feel free to reach out to our development team for further assistance.

Enjoy utilizing the ASP.NET WebAPI with DTO Design Pattern in your own projects!
