Creating this solution using .NET Core including clean architecture.

Need to know the main four layers of clean architecture consist of:
i)  Domain Layer
ii)  Application Layer
iii)  Infrastructure Layer
iv) Presentation Layer

Steps:
1. Create a blank solution
2. Create Student.Domain Class Library project
3. Create Student.Application class Library project
4. Create Student.Infrastructure class Library project
5. Create Student.API ASP.NET Core Web API project

Add Dependency 
i)  Domain Layer to Application Layer
ii)  Domain Layer to Infrastructure Layer
ii) Application Layer and Infrastructure Layer to Presentation Layer

Domain Layer contains Entities.
Infrastructure Layer contains Repository
Application Layer contains Service and Interfaces of Services and Repository
Presentation Layer contains Controllers
