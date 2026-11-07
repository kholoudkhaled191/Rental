# 📸 Camera & Equipment Rental Platform (Backend API)

An enterprise-grade Web API built with *ASP.NET Core for renting photography and film equipment. This project goes beyond basic CRUD operations by focusing on complex business logic, concurrency control, security, and robust backend architecture.

---

## 🚀 Key Features & Business Logic
- **Clean Architecture & CQRS:** Built with a strict multi-layered separation of concerns (Domain, Application, Infrastructure, API).
- **Concurrency Control (Anti-Double Booking):** Implements `Optimistic Concurrency` via EF Core `[Timestamp]` (RowVersion) to prevent overlapping bookings for the same equipment.
- **Full Booking Lifecycle State Machine:** Manages bookings through explicit states: `Pending` -> `Confirmed` -> `PickedUp` -> `Returned` -> `Completed` / `Cancelled` / `Overdue`.
- **Security & Authentication:** Secured using **ASP.NET Core Identity** alongside **JWT & Refresh Tokens**.
- **Collateral & Condition Reports:** Handles security deposits (`Deposit`) and tracks equipment condition reports (`ConditionReport`) at pickup and return to manage damages and refunds.

---

## 🏛️ System Architecture
The project follows **Clean Architecture** principles:
1. **RentalPlatform.Domain:** Enterprise entities, enums, and core business rules (Zero dependencies).
2. **RentalPlatform.Application:** Use cases, interfaces, DTOs, and application logic.
3. **RentalPlatform.Infrastructure:** EF Core, Database Context, Identity configuration, and external services.
4. **RentalPlatform.Api:** Controllers, middlewares, and API configurations.

---

## 🛠️ Tech Stack
* **Framework:** ASP.NET Core Web API (.NET 8)
* **ORM:** Entity Framework Core
* **Database:** SQL Server
* **Authentication:** ASP.NET Core Identity, JWT
* **Validation & Patterns:** FluentValidation, Repository & CQRS patterns

---

## 🗄️ Database Entity Relationship (Core Domain)
* **Product:** Manages equipment details, daily rates, deposit amounts, and concurrency tokens.
* **Booking:** Links users to products across specific date ranges, enforcing conflict-free schedules.
* **Deposit:** Manages financial holds, deductions, and refunds based on item condition.
* **ConditionReport:** Records inspection notes and image proofs during pickup and return.

---

## ⚙️ Getting Started

### Prerequisites
- .NET 8 SDK
- SQL Server (LocalDB or SQL Server Express)

### Installation
1. Clone the repository:
   ```bash
   git clone [https://github.com/YOUR_USERNAME/RentalPlatform.git](https://github.com/YOUR_USERNAME/RentalPlatform.git)
