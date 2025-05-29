using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");
        Order order1 = new Order();
        order1.AddProduct("Allen Wrench, set of 5", "04350", 1, 25);
        order1.AddProduct("Toilet Paper", "03430", 2, 15);
        order1.AddCustomer("Ben");
        order1.SetAddres("7183 S 7123 W", "Riverton", "Utah", "USA");
    }
}