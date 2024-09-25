# Open/Closed Principle Example

This directory contains an example demonstrating the **Open/Closed Principle** (OCP) in C#.

## What is the Open/Closed Principle?

The **Open/Closed Principle** is one of the SOLID principles, stating that:

> **"Software entities should be open for extension, but closed for modification."**

In this example, we show how you can extend functionality (e.g., adding new operations to a calculator) without changing the existing code.

## Example Structure

- `IOperation`: Interface for operations.
- `Addition`, `Subtraction`, `Multiplication`: Concrete implementations of `IOperation`.
- `Calculator`: Uses `IOperation` to perform calculations without needing modification.

## How to Run

1. Clone the repository.
2. Navigate to the `OpenClosed` directory.
3. Run the example in a .NET 8 environment.

---

This project illustrates how to extend functionality while maintaining code integrity.
