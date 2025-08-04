# ➗ MathLibrary (C#)

A lightweight C# class library for basic arithmetic operations, complete with unit tests for functionality and reliability.

---

## 🔢 Available Functions

| Method | Description |
|--------|-------------|
| `Add(int a, int b)` | ➕ Adds two numbers |
| `Subtract(int a, int b)` | ➖ Subtracts one number from another |
| `Multiply(int a, int b)` | ✖️ Multiplies two numbers |
| `Divide(int a, int b)` | ➗ Divides one number by another (handles division by zero) |

---

## 🧪 Unit Tests

### ✅ Tests Performed

1. Addition of large numbers
2. Subtraction resulting in a negative value
3. Multiplication by zero
4. Division with negative numbers
5. Division by zero (expecting an exception)

> ✔️ All unit tests passed successfully, confirming the correctness and robustness of the methods.

---

## 🚀 How to Run the Tests

1. Clone the repository:
```bash
git clone https://github.com/benrafaelchen/MathLibrary.git
cd MathLibrary
```

2. Run tests using the .NET CLI:
```bash
dotnet test
```

---

## 🛠️ Tech Stack

- Language: `C#`
- Platform: `.NET`
- Testing Framework: `xUnit` / `NUnit` / `MSTest` *(choose based on your setup)*

---

## 📌 Notes

- The `Divide` function should be tested for exceptions (`DivideByZeroException`)
- Use `Assert.Throws` in your test framework for expected errors

---

✅ Clean. Tested. Reliable.
