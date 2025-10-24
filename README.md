# 🧠 OOP Examination System (C#)

## 📘 Overview
This project is a **console-based Examination System** built using **Object-Oriented Programming (OOP)** principles in **C#**.  
It simulates how exams are created, managed, and taken for different subjects, supporting multiple exam and question types.  

The project demonstrates practical use of:
- Abstraction and inheritance  
- Polymorphism and encapsulation  
- Composition and relationships between objects  
- Overriding and abstract methods  

---

## 🎯 Project Requirements (Business Case)

### Organization Needs
Your organization needs an **Examination System** with the following specifications:

1. **Question Class**
   - Each question includes:
     - Header  
     - Body  
     - Mark  
   - Different question types inherit from a base `Question` class.

2. **Exam Types**
   - Two types of exams:
     - **Final Exam**
       - Supports **MCQ** and **True/False** questions.
     - **Practical Exam**
       - Supports **MCQ** questions only.

3. **Answer Class**
   - Each question has:
     - A list of possible answers.  
     - A correct answer (RightAnswer).  
     - A user-selected answer (UserAnswer).

4. **Exam Class**
   - Contains:
     - Exam Time (in minutes)
     - Number of Questions
     - List of Questions
   - Has two abstract methods:
     - `CreateListOfQuestions()`  
     - `ShowExam()` (different implementations for each exam type)

5. **Subject Class**
   - Attributes:
     - Subject Id  
     - Subject Name  
     - Subject Exam  
   - Method:
     - `CreateExam()` → Creates either a Final or Practical Exam and populates questions.

6. **Exam Behavior**
   - **Practical Exam:** Shows the right answers after finishing the exam.  
   - **Final Exam:** Shows questions, answers, and user’s grade after submission.

7. **Program Execution**
   - The main program allows:
     - Creating a subject and defining its exam.
     - Taking the exam (timer included).
     - Viewing results after submission.

---

## 🧩 Class Diagram

![UML Diagram](https://github.com/HossamSafa/OOP-Examination-System/blob/master/Final%20OOP%20Exam/uml-diagram.jpg)

---

## 🧠 Core Concepts Used

| Concept | Description |
|----------|-------------|
| **Abstraction** | Implemented via abstract classes `Exam` and `Question`. |
| **Inheritance** | `FinalExam` & `PracticalExam` inherit from `Exam`; `McqQuestion` & `TrueFalseQuestion` inherit from `Question`. |
| **Polymorphism** | Each exam type provides its own implementation of `ShowExam()` and `CreateListOfQuestions()`. |
| **Encapsulation** | All class data (like Answers, Marks) are managed through properties and controlled methods. |
| **Composition** | Each `Exam` contains a collection of `Questions`, and each `Question` contains `Answers`. |
| **Overriding** | `ToString()` method overridden in `Question` class for clean output formatting. |

---

## 💻 How It Works

1. **Run the Program**
   - Create a new **Subject** (for example: “C#”).
   - Choose the **Exam Type** → either **Final** or **Practical**.
   - Define the **Exam Time** (in minutes) and the **Number of Questions**.

2. **Add Questions**
   - For each question:
     - Select **Question Type** → (MCQ / True-False).
     - Enter the **Question Body**, **Mark**, and **Possible Answers**.
     - Specify the **Correct Answer**.

3. **Start Exam**
   - The system starts a **timer** for the exam.
   - The user answers all questions one by one.
   - When the exam is submitted:
     - **Final Exam:** Displays correct answers and total grade.
     - **Practical Exam:** Displays only the correct answers.

4. **End of Exam**
   - The system shows the **final grade** and **total time taken**.


---

## 🧾 Example Console Flow

Select Exam Type: (1 for Practical | 2 for Final)
2

Enter Exam Time (in minutes):
60

Enter Number of Questions:
2

Please Enter Question Type For Question 1 (1 for MCQ | 2 for True / False):
1

Please Enter Question Body:
What is the output of 2 + "2" in C#?

Please Enter Question Mark:
5

Please Enter 3 Possible Answers:
1) 22  
2) 4  
3) Error

Please Enter Right Answer Id:
1

...

Do you want to start exam (Y | N)
Y

---

## ⏱️ Features Summary

✅ Supports multiple question types (MCQ, True/False)  
✅ Two exam modes (Final / Practical)  
✅ Automatic grading system  
✅ Timer for exam duration  
✅ Console-based user interaction  
✅ Object-oriented modular design  
✅ Clean architecture using abstraction & inheritance  

---

## 🧑‍💻 Technologies Used
- **Language:** C#  
- **Framework:** .NET  
- **Paradigm:** Object-Oriented Programming (OOP)
- **IDE:** Visual Studio
