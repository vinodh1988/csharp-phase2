
using System;
using System.IO;

class Program{
    static void Main()
    {
        string filePath = "example.txt";
        try
        {
            // Writing to a file
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine("Hello, World!");
                writer.WriteLine("This is a sample text file.");
            }
            Console.WriteLine("File written successfully.");

            // Reading from a file
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                Console.WriteLine("File contents:");
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        catch (IOException e)
        {
            Console.WriteLine($"An I/O error occurred: {e.Message}");
        }
        catch (Exception e)
        {
            Console.WriteLine($"An unexpected error occurred: {e.Message}");
        }
    }
}
/*using System.Collections;
class Program{

   static void Main()
   {
     try{
        Console.WriteLine("Enter your name:");
        string name = Console.ReadLine();
        Console.WriteLine($"Hello, {name}!");
        Console.WriteLine("Enter years of experience:");
        int years = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"You have {years} years of experience.");
        Console.WriteLine("Enter your salary:");
        double salary = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Your salary is {salary}.");
     }
     catch(FormatException e){
        Console.WriteLine("Input format is incorrect. Please enter valid data.");
     }
     catch(OverflowException e){
        Console.WriteLine("Input value is too large or too small.");
     }
     catch(Exception e){
        Console.WriteLine($"An unexpected error occurred: {e.Message}");
     }
     finally{
        Console.WriteLine("Thank you for using the program.");
     }
   }
}
/*
using System;
using System.Collections.Generic;
Dictionary<string,string> capitals = new Dictionary<string,string>();
capitals["USA"] = "Washington, D.C.";
capitals["France"] = "Paris";
capitals["Japan"] = "Tokyo";
capitals["India"] = "New Delhi";
Console.WriteLine("Dictionary contents:");
foreach(var kvp in capitals)
{
    Console.WriteLine($"{kvp.Key}: {kvp.Value}");
}
Console.WriteLine($"Capital of France: {capitals["France"]}");
Console.WriteLine($"Contains key 'Germany': {capitals.ContainsKey("Germany")}");
Console.WriteLine($"Contains value 'Tokyo': {capitals.ContainsValue("Tokyo")}");
/*
SortedSet<int> numbers = new SortedSet<int>();
numbers.Add(10);
numbers.Add(20);
numbers.Add(30);
numbers.Add(15);
numbers.Add(25);
numbers.Add(5);
numbers.Add(20); // Duplicate, will be ignored
Console.WriteLine("HashSet contents:");
Console.WriteLine(string.Join(", ", numbers));
Console.WriteLine($"Contains 20: {numbers.Contains(20)}");
Console.WriteLine($"Contains 40: {numbers.Contains(40)}");
numbers.Remove(20);
Console.WriteLine("HashSet contents after removing 20:");
Console.WriteLine(string.Join(", ", numbers));
foreach(var num in numbers)
{
    Console.WriteLine($"Number: {num}");
}
/*

List<String> names = new List<String>();
names.Add("Rajan");
names.Add("Anu");
names.Add("Sita");
names.Add("Gita");
Console.WriteLine("List contents:");
Console.WriteLine(string.Join(", ", names));
names.Insert(2, "Mohan");
Console.WriteLine("List contents after adding at index 2:");
Console.WriteLine(string.Join(", ", names));
names.Remove("Sita");
Console.WriteLine("List contents after removing Sita:");
Console.WriteLine(string.Join(", ", names));
names.RemoveAt(1);
Console.WriteLine("List contents after removing at index 1:");
Console.WriteLine(string.Join(", ", names));
names.Sort();
Console.WriteLine("List contents after sorting:");
Console.WriteLine(string.Join(", ", names));
names.Add("Rajan");
names.Add("Anu");
Console.WriteLine("List contents after adding duplicates:");
Console.WriteLine(string.Join(", ", names));
Console.WriteLine($"Index of Anu: {names.IndexOf("Anu")}");
foreach(var name in names)
{
    Console.WriteLine($"Name: {name}");
}
/*
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

