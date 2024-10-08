Creating this solution using .NET Core including clean architecture.

Need to know the main four layers of clean architecture consist of:
1.  Domain Layer
2.  Application Layer
3.  Infrastructure Layer
4. Presentation Layer

Steps:
1. Create a blank solution
2. Create Student.Domain Class Library project
3. Create Student.Application class Library project
4. Create Student.Infrastructure class Library project
5. Create Student.API ASP.NET Core Web API project

Add Dependency 
1.  Domain Layer to Application Layer
2.  Domain Layer to Infrastructure Layer
3. Application Layer and Infrastructure Layer to Presentation Layer

Final Steps:
1.  Domain Layer contains Entities.
2.  Infrastructure Layer contains Repository
3.  Application Layer contains Service and Interfaces of Services and Repository
4.  Presentation Layer contains Controllers
