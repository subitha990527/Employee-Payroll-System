# Employee Payroll System 

## Overview

This project is a **C# Console Application** that implements an **Employee Payroll System** using **Object-Oriented Programming (OOP)** principles. The system allows for managing employee records, calculating salaries, and displaying payroll details. It is designed to be modular, reusable, and easy to maintain.

## Features

1. **Employee Management:**
   - Add new employees with details such as Name, ID, Role, Basic Pay, and Allowances.
   - Display a list of all employees with their details.

2. **Salary Calculation:**
   - Calculate individual employee salaries using the formula:  
     **Salary = Basic Pay + Allowances - Deductions**.
   - Display the calculated salary for each employee.

3. **Role-Specific Classes:**
   - The system uses OOP principles with a base class `BaseEmployee` and specialized classes for different roles (`Manager`, `Developer`, `Intern`).
   - Each role can have specific attributes or methods if needed.

4. **Menu-Driven Interface:**
   - The application provides a user-friendly menu-driven interface with options to:
     - Add new employees.
     - Display all employee details.
     - Calculate and display individual salaries.
     - Calculate and display the total payroll for all employees.

## How to Run the Application

1. **Prerequisites:**
   - Ensure you have the .NET SDK installed on your machine.

2. **Clone the Repository:**
   - Clone this repository to your local machine using the following command:
     ```bash
     git clone https://github.com/subitha990527/Employee-Payroll-System.git
     ```

3. **Build and Run the Application:**
   - Build and run the application using the following commands:
     ```bash
     dotnet build
     dotnet run
     ```

4. **Using the Application:**
   - Follow the on-screen menu prompts to:
     - Add new employees.
     - View employee details.
     - Calculate and display salaries.
     - Calculate the total payroll.

## Documentation

- **Code Documentation**: The code is well-commented, explaining the purpose of each class, method, and key logic.
- **Design Choices**: The application follows OOP principles, ensuring modularity and reusability. The use of inheritance and polymorphism allows for easy extension of the system with new roles or features.

