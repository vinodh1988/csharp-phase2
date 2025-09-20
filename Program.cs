
using System;
using System.Collections.Generic;

Queue<int> queue = new Queue<int>();
queue.Enqueue(10);
queue.Enqueue(20);
queue.Enqueue(30);
Console.WriteLine("Queue contents:");
Console.WriteLine(string.Join(", ", queue));
Console.WriteLine($"Dequeued item: {queue.Dequeue()}");
Console.WriteLine("Queue contents after dequeue:");
Console.WriteLine(string.Join(", ", queue));
Console.WriteLine("Peeking front item:");
Console.WriteLine($"Front item: {queue.Peek()}");
foreach(var item in queue)
{
    Console.WriteLine($"Item: {item}");
}
/*
Stack stack = new Stack();
stack.Push(10);
stack.Push("Rajan");
stack.Push(30);
Console.WriteLine("Stack contents:");
Console.WriteLine(string.Join(", ", stack));
Console.WriteLine($"Popped item: {stack.Pop()}");
Console.WriteLine("Stack contents after pop:");
Console.WriteLine(string.Join(", ", stack));
Console.WriteLine("Peeking top item:");
Console.WriteLine($"Top item: {stack.Peek()}");
foreach(var item in stack)
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

