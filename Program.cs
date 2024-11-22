// See https://aka.ms/new-console-template for more information


using System;

class Program
{
    public static void Main()
    {
        
        string[] products = { "Milk", "Yoghurt", "Cream", "Cottage Cheese" };

        
        foreach (string product in products)
        {
            Console.WriteLine("Product: " + product);
        }
        Console.ReadKey();
    }
}