# 🎓 BMT110 - Student Information System (OBS)

![Language](https://img.shields.io/badge/Language-C%2B%2B-00599C?style=flat&logo=c%2B%2B&logoColor=white)
![Type](https://img.shields.io/badge/Type-Console_Application-lightgrey)
![Course](https://img.shields.io/badge/Course-BMT110-blue)


**BMT110_OBS_Project** is a C++ console application developed as a final assignment for the BMT110 course. It serves as a **Student Grade Management System**, allowing users to input student data, calculate academic averages based on exam scores, and determine pass/fail status.

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

This project demonstrates the practical application of fundamental programming logic. It replaces manual grade calculation with an automated system that processes student scores (Midterm/Final) to generate a final academic standing.

**Core Objectives:**
* Automate grade calculation (Weighted Average).
* Manage student records using basic data structures.
* demonstrate proficiency in C++ syntax and logic.

---

## 🚀 Key Features

* **Student Data Entry:** Input student ID, names, and exam scores via the console.
* **Grade Calculation:** Automatically computes the weighted average of Midterm (Vize) and Final exams.
* **Status Determination:** logic to determine if a student Passed or Failed based on the calculated average.
* **Letter Grade System:** (Optional) Assigns letter grades (AA, BA, BB, etc.) based on the numerical score.
* **User-Friendly Interface:** Clear menu-driven console interface for easy navigation.

---

## 💻 Technical Concepts

This project was built to demonstrate mastery of the following C++ concepts:

* **Control Structures:** `if-else` statements for grade logic and `switch-case` for menus.
* **Loops:** `for` and `while` loops for iterating through student lists.
* **Arrays/Vectors:** Storing student data efficiently.
* **Functions:** Modular code structure for specific tasks (e.g., `calculateAverage()`).
* **I/O Operations:** Standard input/output using `cin` and `cout`.

---

## ⚙️ Installation & Execution

To run this project, you need a C++ compiler (like GCC) or an IDE (like Dev-C++, Code::Blocks, or Visual Studio).

1.  **Clone the repository:**
    ```bash
    git clone [https://github.com/BayramEnesAtay/BMT110_OBS_Project.git](https://github.com/BayramEnesAtay/BMT110_OBS_Project.git)
    ```

2.  **Navigate to the directory:**
    ```bash
    cd BMT110_OBS_Project
    ```

3.  **Compile the code:**
    ```bash
    g++ main.cpp -o obs_system
    ```

4.  **Run the application:**
    ```bash
    ./obs_system
    ```

---

## 📝 Usage

1.  Launch the application.
2.  Select an option from the main menu (e.g., "Add Student", "Calculate Grades").
3.  Enter the required details (Student Number, Midterm Score, Final Score).
4.  View the calculated results and pass/fail status immediately.

---
