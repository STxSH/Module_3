using System;

class MainClass
{
    public static void Main(string[] args)
    {

        const string MyName = "Антон";

        Console.WriteLine(MyName);

        Console.WriteLine("\t Привет Мир");
        Console.WriteLine("\t Мне 28 лет");
        Console.WriteLine("\t My name is \n {0}", MyName);
        Console.WriteLine("\u0040");
        Console.WriteLine('\x23');
        Console.WriteLine((char)35);
        Console.ReadKey();

    }
}