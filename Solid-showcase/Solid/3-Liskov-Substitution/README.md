# Liskov Substitution Principle Example

This directory contains an example demonstrating the **Liskov Substitution Principle** (LSP) in C#.

## What is the Liskov Substitution Principle?

The **Liskov Substitution Principle** is one of the SOLID principles, stating that:

> **"Objects of a superclass should be replaceable with objects of a subclass without affecting the correctness of the program."**

In this example, we show how different calculators (addition, subtraction) follow LSP by using a base class.

## Example Structure

- `BaseCalculator`: Abstract base class for different operations.
- `AdditionCalculator`, `SubtractionCalculator`: Subclasses implementing different operations.
- `Program`: Demonstrates the usage of substitution between classes.

## How to Run

1. Clone the repository.
2. Navigate to the `LiskovSubstitution` directory.
3. Run the example in a .NET 8 environment.

---

This project illustrates how subclasses can replace base classes while preserving the correct behavior of the program.
