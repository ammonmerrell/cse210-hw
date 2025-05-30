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
        string _packingLabel;
        string _shipingLabel;
        string _customer = "";
        int _price;
        _packingLabel = order1.PackingLabel();
        _shipingLabel = order1.ShipingLabel();
        Console.WriteLine(order1.ShowCustomerInfo());
        Console.WriteLine($"Packing label is: {_packingLabel}");
        Console.WriteLine($"Shiping label is: {_shipingLabel}");
        _price = order1.TotalCost();
        Console.WriteLine(_price);

        Order order2 = new Order();
        order2.AddProduct("Sprite, set of 6", "12340", 2, 30);
        order2.AddProduct("Microwave Pop", "02750", 1, 35);
        order2.AddCustomer("Jef");
        order2.SetAddres("1234 S 4321 W", "Silverton", "London", "ENGLAND");
        
        _packingLabel = order2.PackingLabel();
        _shipingLabel = order2.ShipingLabel();
        Console.WriteLine(order2.ShowCustomerInfo());
        Console.WriteLine($"Packing label is: {_packingLabel}");
        Console.WriteLine($"Shiping label is: {_shipingLabel}");
        _price = order2.TotalCost();
        Console.WriteLine(_price);



    }
}