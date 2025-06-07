using System;
using System.Data;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;

class Program
{
    
    static void Main(string[] args)
    {
        string _input = "";

        Console.WriteLine("Hello World! This is the Mindfulness Project.");
        
        Activity act = new Activity();
        Breathing bre = new Breathing();
        Reflect refl = new Reflect();
        Listing lis = new Listing();
        while (_input != "4")
        {
        Console.WriteLine("Options:");
        Console.Write("1. Breathing Activity\n2. Reflecion Activity\n3. Listing Activity\n4. Quit\nType the number: ");
            _input = Console.ReadLine();
            if (_input == "1")
            {
                bre.Run();
            }
            if (_input == "2")
            {
                refl.Run();
            }
            if (_input == "3")
            {
                lis.run(); 
            }
        
          
        }
        
    }
}