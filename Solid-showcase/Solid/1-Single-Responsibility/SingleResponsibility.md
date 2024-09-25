# Single Responsibility Principle Example

This directory contains an example demonstrating the **Single Responsibility Principle** (SRP) in C#.

## What is the Single Responsibility Principle?

The **Single Responsibility Principle** is one of the SOLID principles, stating that:

> **"A class should have only one reason to change."**

In this example, we split the responsibilities into multiple classes to ensure each class has a single purpose (e.g., input handling and greeting generation).

## Example Structure

- `UserInput`: Handles user input.
- `GreetingService`: Handles greeting logic.
- `Program`: Main entry point that coordinates the other classes.

## How to Run

1. Clone the repository.
2. Navigate to the `SingleResponsibility` directory.
3. Run the example in a .NET 8 environment.

---

This project illustrates how to adhere to the SRP by separating concerns into dedicated classes.