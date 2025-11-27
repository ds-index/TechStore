# 🏬 TechStore

### Modern E-Commerce backend built with Clean Architecture, CQRS, MediatR & Entity Framework Core

TechStore is a modular, scalable, and maintainable e-commerce backend designed using **Clean Architecture**, **Domain-Driven Design (DDD)**, **CQRS**, and **MediatR**.
The project follows industry best practices and provides a solid foundation for building enterprise-grade applications.

---

## 🚀 Features

### 🧱 Architecture

* Clean Architecture (Domain → Application → Infrastructure → API)
* Strict separation of concerns
* Flexible and testable design
* DTO mapping using AutoMapper
* Repository and Unit of Work patterns

### ⚙ CQRS + Mediator

* Clear separation between Commands & Queries
* MediatR pipelines (validation, logging, performance)
* Fully async handlers

### 🗄 Entity Framework Core

* Code-first migrations
* Relational mapping and configuration
* InMemory database for testing
* Soft-delete & concurrency ready

### 🧪 Unit & Integration Testing

* xUnit test framework
* Moq mocking library
* EF Core InMemory provider
* Clean Arrange–Act–Assert structure

---

## 📦 Project Structure

```
TechStore/
│
├── TechStore.Domain/           # Entities, enums, value objects, base models
├── TechStore.Application/      # CQRS (Commands & Queries), services, interfaces
├── TechStore.Infrastructure/   # EF Core, repositories, configurations
├── TechStore.Shared/           # Shared models and utilities
├── TechStore.WebAPI/           # API endpoints, DI, controllers, middlewares
└── TechStore.Tests/            # Unit & integration tests
```

---

## 🏗 Tech Stack

| Layer              | Technology                  |
| ------------------ | --------------------------- |
| **API**            | ASP.NET Core 8              |
| **Application**    | MediatR, FluentValidation   |
| **Infrastructure** | Entity Framework Core       |
| **Domain**         | Clean Architecture / DDD    |
| **Testing**        | xUnit, Moq, EFCore.InMemory |
| **Tools**          | AutoMapper, Swagger         |

---

## 📥 Getting Started

### Clone the repository

```bash
git clone https://github.com/ds-index/TechStore.git
cd TechStore
```

### Install dependencies

```bash
dotnet restore
```

### Run the API

```bash
cd TechStore.WebAPI
dotnet run
```

API will start on:

```
https://localhost:7185
http://localhost:5185
```

Swagger documentation available at:

```
/swagger
```

---

## 🧪 Running Tests

```bash
cd TechStore.Tests
dotnet test
```

---

## 🧭 Example CQRS Flow

### CreateProductCommand.cs

```csharp
public record CreateProductCommand(string Name, decimal Price) 
    : IRequest<Guid>;
```

### CreateProductHandler.cs

```csharp
public class CreateProductHandler : IRequestHandler<CreateProductCommand, Guid>
{
    private readonly IProductRepository _repo;

    public CreateProductHandler(IProductRepository repo)
    {
        _repo = repo;
    }

    public async Task<Guid> Handle(CreateProductCommand request, CancellationToken cancellationToken)
    {
        var product = new Product(request.Name, request.Price);
        await _repo.AddAsync(product);
        return product.Id;
    }
}
```

---

## 🧭 Roadmap

* [ ] Add authentication (JWT + Identity)
* [ ] Add basket module
* [ ] Add order management
* [ ] Add SQL Server integration tests
* [ ] Add Docker support
* [ ] Add caching (Redis)

---

## 🤝 Contributing

Contributions are welcome!
Feel free to open an issue or submit a pull request.

---

## 📜 License

This project is licensed under the **MIT License**.
