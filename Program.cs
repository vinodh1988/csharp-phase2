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
