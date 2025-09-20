
using System;
using System.Collections.Generic;

Stack<int> stack = new Stack<int>();
stack.Push(10);
stack.Push(20);
stack.Push(30);
Console.WriteLine("Stack contents:");
Console.WriteLine(string.Join(", ", stack));
Console.WriteLine($"Popped item: {stack.Pop()}");
Console.WriteLine("Stack contents after pop:");
Console.WriteLine(string.Join(", ", stack));
Console.WriteLine("Peeking top item:");
Console.WriteLine($"Top item: {stack.Peek()}");
foreach(int item in stack)
{
    Console.WriteLine($"Item: {item}");
}


/*
using System;
using phase2;

class Program
{
     static void Main()
        {
            Store<int> intStore = new Store<int>();
            intStore.Data = 42;
            intStore.DisplayType();
            intStore.DisplayData();
            Store<string> stringStore = new Store<string>();
            stringStore.Data = "Hello, Generics!";
            stringStore.DisplayType();
            stringStore.DisplayData();
            Store<double> doubleStore = new Store<double>();
            doubleStore.Data = 3.14;
            doubleStore.DisplayType();
            doubleStore.DisplayData();
    
     }
}
*/

