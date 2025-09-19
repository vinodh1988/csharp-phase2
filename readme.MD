# Exception Handling in C#

Exception handling in C# is a mechanism to handle runtime errors, ensuring the program can continue execution or terminate gracefully. It uses the `try`, `catch`, `finally`, and `throw` keywords.

## Basic Syntax

```csharp
try
{
    // Code that may throw an exception
}
catch (ExceptionType ex)
{
    // Code to handle the exception
}
finally
{
    // Optional block to execute cleanup code
}
```

## Example

```csharp
using System;

class Program
{
    static void Main()
    {
        try
        {
            int num = int.Parse("NotANumber");
        }
        catch (FormatException ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            Console.WriteLine("Execution completed.");
        }
    }
}
```

## Key Points
- **`try`**: Defines a block of code to monitor for exceptions.
- **`catch`**: Handles the exception.
- **`finally`**: Executes code regardless of whether an exception occurred.
- **`throw`**: Used to explicitly throw an exception.

## Common Exceptions
- `NullReferenceException`
- `IndexOutOfRangeException`
- `InvalidOperationException`
- `DivideByZeroException`

Use exception handling judiciously to maintain code clarity and performance.