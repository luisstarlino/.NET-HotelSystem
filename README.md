# 🏢 Hotel System - Console App 🖥️

![.NET](https://img.shields.io/badge/6.0-512BD4?style=flat&logo=dotnet&logoColor=white) ![Status](https://img.shields.io/badge/Status-Completed-brightgreen?style=flat)


## 🖊️ About
The **Hotel System Console App** is a **Console Application** built with **.NET 6.0**.  

Its main objective is to provide an intuitive interface for managing hotel operations, including guests, suites and reservations. This application features a **menu-driven** system for navigation and is ideal for demonstrating back-end logic and basic data management.


> Based on the "DIO" .NET course, by Leonardo Buta, with improvements implemented for a more automated dynamic system.

## 💻 Technologies Used
- 🔣 **.NET 6.0**: A modern, cross-platform framework for building applications.  

## 🔵 The Real Challenge - Based on the curse

The program must correctly calculate the values of the methods of the Reservation class, which will need to provide the number of guests and the daily rate, granting a 10% discount if the reservation is for a period longer than 10 days.

## 🚀 Features
- **Integrated Menu System**: Navigate through functionalities with ease.  
- **Entity-Relationship Model**: Supports key entities such as `Person`, `Suite`, and `Reservation`.  
- **Reservation Methods**: Implements three core methods for managing reservations:
  - Calculate total stay cost.
  - Add a new reservation.
  - Display reservation details.


## 🛠️ Installation and Setup
1. Clone the repository:
   ```bash
   git clone https://github.com/luisstarlino/.NET-HotelSystem
   ```

2. Navigate to the project directory:
   ```bash
   cd .NET-HotelSystem
   ```

3. Build and run the application:
   ```bash
   dotnet build
   dotnet run
   ```

---

## 🗉️ Menu Options
The application provides a menu-driven system with the following options:

![Diagrama de classe estacionamento](/demo/demo-4.png)


## 📄 Entity-Relationship Model

### **Entities**
1. **Person**: Represents a guest with relevant details.  
2. **Suite**: Represents a suite with attributes like number, capacity, and price.  
3. **Reservation**: Links `Person` and `Suite` and provides functionality for:  
   - **Calculating total stay cost**.  
   - **Adding a new reservation**.  
   - **Displaying reservation details**.

![Diagrama de classe estacionamento](diagrama_classe_hotel.png)

## 🌆 System Demo 

### List All Suites
![Diagrama de classe estacionamento](/demo/demo-1.png)

### New Suite
![Diagrama de classe estacionamento](/demo/demo-2.png)

### All Reservations
![Diagrama de classe estacionamento](/demo/demo-3.png)
