# Interface Segregation Principle (ISP) Example

This directory demonstrates the **Interface Segregation Principle (ISP)** in C#.

## What is the Interface Segregation Principle?

The **Interface Segregation Principle** is one of the SOLID principles, stating that:

> **"No client should be forced to depend on methods it does not use."**

Large, all-encompassing interfaces should be split into smaller, more specific ones so that clients only implement the methods they need.

## Example Structure

- `IPrinter`: Interface for printing functionality.
- `IScanner`: Interface for scanning functionality.
- `IFax`: Interface for faxing functionality.
- `MultiFunctionPrinter`: Implements all interfaces (`IPrinter`, `IScanner`, `IFax`).
- `OldPrinter`: Only implements `IPrinter`.

## How to Run

1. Clone the repository.
2. Navigate to the `InterfaceSegregation` directory.
3. Run the example in a .NET 8 environment.

---

This example illustrates how to apply the **Interface Segregation Principle** by creating smaller, focused interfaces to avoid unnecessary method implementations.
