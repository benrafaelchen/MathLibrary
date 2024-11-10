# MathLibrary

## Project Overview
MathLibrary is a simple C# library that provides basic arithmetic operations with unit tests to ensure functionality and accuracy.

## Unit Test Documentation

### Tested Functions
- **`Add(int a, int b)`** - Adds two numbers.
- **`Subtract(int a, int b)`** - Subtracts one number from another.
- **`Multiply(int a, int b)`** - Multiplies two numbers.
- **`Divide(int a, int b)`** - Divides one number by another, handling division by zero.

### Key Tests Performed
1. **Testing addition of large numbers** – Verifies addition with large integer values.
2. **Testing subtraction resulting in a negative value** – Ensures subtraction correctly handles negative results.
3. **Testing multiplication by zero** – Checks that multiplication by zero returns zero.
4. **Testing division with negative numbers** – Confirms division works with negative numbers.
5. **Testing division by zero** – Ensures the function throws an exception when dividing by zero.

### Test Results
All tests passed successfully, validating the accuracy and reliability of each function.

## How to Run the Tests

1. Clone the repository:
   ```bash
   git clone https://github.com/benrafaelchen/MathLibrary.git
