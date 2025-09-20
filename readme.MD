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


Collections

## Collections in C#

Collections in C# are used to store, manage, and manipulate groups of related objects. The `System.Collections` and `System.Collections.Generic` namespaces provide various types of collections.

### Common Collection Types

1. **Array**  
    Fixed-size collection of elements of the same type.
    ```csharp
    int[] numbers = { 1, 2, 3, 4, 5 };
    ```

2. **List<T>**  
    Dynamic-size collection of elements of the same type.
    ```csharp
    using System.Collections.Generic;

    List<int> numbers = new List<int> { 1, 2, 3 };
    numbers.Add(4);
    ```

3. **Dictionary<TKey, TValue>**  
    Key-value pair collection.
    ```csharp
    using System.Collections.Generic;

    Dictionary<int, string> students = new Dictionary<int, string>
    {
         { 1, "Alice" },
         { 2, "Bob" }
    };
    ```

4. **Queue<T>**  
    First-in, first-out (FIFO) collection.
    ```csharp
    using System.Collections.Generic;

    Queue<string> tasks = new Queue<string>();
    tasks.Enqueue("Task1");
    tasks.Enqueue("Task2");
    ```

5. **Stack<T>**  
    Last-in, first-out (LIFO) collection.
    ```csharp
    using System.Collections.Generic;

    Stack<string> history = new Stack<string>();
    history.Push("Page1");
    history.Push("Page2");
    ```

### Choosing the Right Collection
- Use `List<T>` for dynamic lists.
- Use `Dictionary<TKey, TValue>` for key-value pairs.
- Use `Queue<T>` for FIFO operations.
- Use `Stack<T>` for LIFO operations.

Collections simplify data management and improve code readability.

## Generic vs Non-Generic Collections

C# provides both generic and non-generic collections. Understanding their differences helps in choosing the right collection for your needs.

### Non-Generic Collections
Non-generic collections are found in the `System.Collections` namespace. They store objects as `System.Object`, requiring boxing/unboxing for value types.

#### Examples:
1. **ArrayList**  
    A dynamically sized array.
    ```csharp
    using System.Collections;

    ArrayList list = new ArrayList();
    list.Add(1);
    list.Add("Hello");
    ```

2. **Hashtable**  
    A collection of key-value pairs.
    ```csharp
    using System.Collections;

    Hashtable table = new Hashtable();
    table.Add(1, "Alice");
    table.Add(2, "Bob");
    ```

### Generic Collections
Generic collections are found in the `System.Collections.Generic` namespace. They are type-safe and avoid boxing/unboxing.

#### Examples:
1. **List<T>**  
    A dynamically sized, type-safe list.
    ```csharp
    List<int> numbers = new List<int> { 1, 2, 3 };
    ```

2. **Dictionary<TKey, TValue>**  
    A type-safe key-value pair collection.
    ```csharp
    Dictionary<int, string> students = new Dictionary<int, string>
    {
         { 1, "Alice" },
         { 2, "Bob" }
    };
    ```

### Key Differences
| Feature               | Non-Generic Collections | Generic Collections      |
|-----------------------|-------------------------|--------------------------|
| Type Safety           | No                      | Yes                      |
| Performance           | Slower (boxing/unboxing)| Faster                   |
| Namespace             | `System.Collections`    | `System.Collections.Generic` |

### Recommendation
Use generic collections whenever possible for better performance and type safety.