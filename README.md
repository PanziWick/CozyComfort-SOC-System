# CozyComfort SOC System

## Overview
This project implements a **Service-Oriented Architecture (SOC)** solution for "Cozy Comfort," a blanket manufacturer that interacts with distributors and sellers.  
The system modernizes their order and inventory processes by introducing:
- A **Central API (ASP.NET Core Web API)** for all business logic and database access
- **Manufacturer Desktop App (Windows Forms)** to manage blanket production
- **Distributor Web App (ASP.NET MVC)** to manage distributor inventory and seller orders
- **Seller Web App (ASP.NET MVC)** to manage seller orders and stock

---

## 🎯 Features
- **Manufacturer**: Manage blankets, update production stock
- **Distributor**: View inventory, approve/ship seller orders, request stock
- **Seller**: Place orders, track order statuses, manage inventory
- Built on **.NET 8, EF Core, SQL Server**, and containerized for deployment

---

## 🏗️ Architecture

The system follows SOC:
- Clients (Desktop/Web) communicate with a **central API** only.
- **API handles DB interactions** via Entity Framework Core.
- Independent modules for **Manufacturer**, **Distributor**, and **Seller** services.

---

## 🔧 Prerequisites
- [.NET 8 SDK](https://dotnet.microsoft.com/en-us/download)
- [Visual Studio 2022+](https://visualstudio.microsoft.com/) (with ASP.NET workload)
- SQL Server (LocalDB or Express recommended)
- Git

---

## 🚀 Setup & Run
1. **Clone repo**:
   ```bash
   git clone https://github.com/<your-username>/CozyComfort-SOC-System.git
   
2. **API Setup**:
- Open CozyComfort.Services in Visual Studio
- Update appsettings.json connection string
Run:
```
Update-Database
```
- Start API (Swagger UI available)

3. **Manufacturer Desktop App**:
- Open Manufacturer.Desktop → Run
- Connects automatically to API endpoints (set base URL in BlanketService.cs)

4. **Distributor Web App**:
- Open Distributor.Web → Run
- View inventory and manage orders

5. **Seller Web App**:
- Open Seller.Web → Run
- Place and track orders

