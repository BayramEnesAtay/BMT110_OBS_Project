# 🎓 BMT110 - Student Information System (OBS)

![Language](https://img.shields.io/badge/Language-C%23-239120?style=flat&logo=c-sharp&logoColor=white)
![Platform](https://img.shields.io/badge/Platform-.NET-512BD4?style=flat&logo=.net&logoColor=white)
![Type](https://img.shields.io/badge/Type-Console_Application-lightgrey)


**BMT110_OBS_Project** is a C# console application developed as a final assignment for the BMT110 course. It serves as a **Student Grade Management System**, allowing users to input student data, calculate academic averages based on exam scores, and determine pass/fail status using .NET fundamentals.

---

## 📋 Table of Contents
- [Overview](#-overview)
- [Key Features](#-key-features)
- [Technical Concepts](#-technical-concepts)
- [Installation & Execution](#-installation--execution)
- [Usage](#-usage)
- [License](#-license)

---

## 🎯 Overview

This project demonstrates the practical application of Object-Oriented Programming (OOP) and structural logic in C#. It replaces manual grade calculation with an automated system that processes student scores (Midterm/Final) to generate a final academic standing.

**Core Objectives:**
* Automate grade calculation (Weighted Average).
* Manage student records using classes and arrays.
* Demonstrate proficiency in C# syntax and the .NET environment.

---

## 🚀 Key Features

* **Student Data Entry:** Input student ID, names, and exam scores via the console.
* **Grade Calculation:** Automatically computes the weighted average of Midterm (Vize) and Final exams.
* **Status Determination:** Logic to determine if a student Passed or Failed based on the calculated average.
* **Letter Grade System:** Assigns letter grades (AA, BA, BB, etc.) based on the numerical score.
* **User-Friendly Interface:** Clear menu-driven console interface for easy navigation.

---

## 💻 Technical Concepts

This project was built to demonstrate mastery of the following C# concepts:

* **Classes & Objects:** Encapsulating student data within custom classes.
* **Control Structures:** `if-else` statements for grade logic and `switch` blocks for menus.
* **Collections:** Using Arrays or Lists to store multiple student records.
* **Methods:** Modular code structure for specific tasks (e.g., `CalculateAverage()`).
* **Console I/O:** Using `Console.WriteLine` and `Console.ReadLine` for user interaction.

---

## ⚙️ Installation & Execution

To run this project, you need **Visual Studio** or the **.NET SDK** installed on your machine.

### Option 1: Using Visual Studio
1.  **Clone the repository:**
    ```bash
    git clone [https://github.com/BayramEnesAtay/BMT110_OBS_Project.git](https://github.com/BayramEnesAtay/BMT110_OBS_Project.git)
    ```
2.  **Open the Project:**
    * Launch Visual Studio.
    * Select "Open a project or solution".
    * Navigate to the cloned folder and select the `.sln` or `.csproj` file.
3.  **Run:**
    * Press **F5** or click the **Start** button to build and run the application.

### Option 2: Using .NET CLI
1.  **Navigate to the directory:**
    ```bash
    cd BMT110_OBS_Project
    ```
2.  **Run the application:**
    ```bash
    dotnet run
    ```

---

## 📝 Usage

1.  Launch the application.
2.  Select an option from the main menu (e.g., "Add Student", "Show Results").
3.  Enter the required details (Student Number, Midterm Score, Final Score).
4.  View the calculated results and pass/fail status immediately.

---
