# PRAS - Patient Registration and Appointment System

PRAS is a desktop-based hospital management and appointment system developed with C#, WinForms, and SQL Server.

The project is designed to simplify core hospital workflows such as patient registration, doctor management, appointment scheduling, and secretary operations through a structured and maintainable architecture.

## Overview

The purpose of this project is to simulate a real-world hospital automation system while applying software engineering principles such as layered architecture, object-oriented programming, and database management.

Users can interact with the system according to their roles and manage appointments, doctors, patients, and departments efficiently.

## Features

### Patient Management
- Register and manage patient information
- Book appointments
- View appointment history
- Update profile information

### Doctor Management
- View appointments
- Access patient information
- Manage appointment schedules

### Secretary Operations
- Create appointments
- Register new patients
- Manage doctors and departments
- Organize hospital workflow

### System Features
- Multi-role management system
- Appointment scheduling
- SQL Server database integration
- Layered software architecture
- Clean and maintainable project structure

### Layers

**PRAS.App**  
Responsible for the user interface and user interaction.

**PRAS.Business**  
Contains the business rules and application logic.

**PRAS.DataAccess**  
Handles database communication and CRUD operations.

**PRAS.Core**  
Contains shared utilities and reusable functionality.

## Installation

### Requirements

Before running the project, make sure the following tools are installed:

- Visual Studio 2022 or newer
- .NET SDK
- SQL Server

### Setup

Clone the repository:

```bash
git clone https://github.com/berkecuhadar/PRAS.git
```

Navigate to the project directory:

```bash
cd PRAS
```

Configure the database connection string in the appropriate configuration file.

Import the database into SQL Server.

Open the solution file:

```txt
PRAS.sln
```

Run the project through Visual Studio.

## Database

The system stores and manages data using SQL Server.

Core entities include:

- Patients
- Doctors
- Appointments
- Secretaries


## Purpose of the Project

This project was created to improve practical experience in:

- Object-oriented programming
- Layered architecture
- SQL database integration
- Desktop application development
- Software structure and maintainability

## Contributing

Contributions, suggestions, and improvements are welcome. Feel free to fork the repository and submit a pull request.

## License

This project is licensed under the MIT License.