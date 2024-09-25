# Dependency Inversion Principle (DIP) Example

This directory demonstrates the **Dependency Inversion Principle** (DIP) in C#.

## What is the Dependency Inversion Principle?

The **Dependency Inversion Principle** is one of the SOLID principles, stating that:

> **"High-level modules should not depend on low-level modules. Both should depend on abstractions."**

It ensures that code is more flexible and easier to maintain by reducing dependencies on specific implementations.

## Example Structure

- `IMessageService`: Abstraction for message services.
- `EmailService`: Concrete implementation of `IMessageService`.
- `Notification`: Depends on `IMessageService`, allowing flexibility in message delivery services.

## How to Run

1. Clone the repository.
2. Navigate to the `DependencyInversion` directory.
3. Run the example in a .NET 8 environment.

---

This example illustrates how the **Dependency Inversion Principle** can improve flexibility and testability by relying on abstractions rather than concrete classes.
