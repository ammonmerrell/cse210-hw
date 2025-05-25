using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Scripture _aScripture = new Scripture();
        string _scrip = "";
        int _index;
        int _num;
        string _input = "";
        while (_input == "")
        {
            Reference aRef = new Reference();
            _index = aRef.GetRandomNumber();
            _scrip = aRef.GetVerse(_index);
            Console.WriteLine(_scrip);

            _scrip = _aScripture.GetScripture(_index);
            Console.WriteLine(_scrip);
            Console.WriteLine("Press enter to remove words, press 'quit' to finish.");
            _input = Console.ReadLine();
            _aScripture.HideWord();
            

            // List<string> words = new List<string>();

            // words.Add("phone");
            // words.Add("keyboard");
            // words.Add("mouse");
            // foreach (string i in words)
            // {
            //     Console.Write(" ");
            //  Console.Write(i);   
            // }

        }
    }
}