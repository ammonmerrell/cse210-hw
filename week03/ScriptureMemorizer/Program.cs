using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        // Console.WriteLine("Hello World! This is the ScriptureMemorizer Project.");
        Scripture _aScripture = new Scripture();
        string _ref;
        string _scrip;
        int _index;
        int _num;
        string _input = "";
        string _list;
        
            
        Reference aRef = new Reference();
        _index = aRef.GetRandomNumber();
        _ref = aRef.GetVerse(_index);
        _scrip = _aScripture.GetScripture(_index);

        Console.WriteLine(_ref);
        Console.WriteLine(_scrip);


        Console.WriteLine();
        Console.WriteLine("Press enter to remove words, press 'quit' to finish.");
        _input = Console.ReadLine();
        _aScripture.HideWord();

        while (_input == "")
        {


            Console.WriteLine();
            Console.WriteLine("Press enter to remove words, press 'quit' to finish.");
            _input = Console.ReadLine();
            _list =_aScripture.HideWord();




            // Console.Clear();


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