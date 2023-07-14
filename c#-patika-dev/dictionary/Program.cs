using System;
using System.Collections.Generic;



namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            // system.collections.generic
            Dictionary<string, int> users = new Dictionary<string, int>();

            users.Add("Ayşe", 21);
            users.Add("Ali", 32);
            users.Add("Mehmet", 18);
            users.Add("Ahmet", 21);

            // Dizinin Elemanlarına Erişim
            Console.WriteLine("*** Elemanlara Erişim ***");
            Console.WriteLine(users["Ayşe"]);
            foreach (var item in users)
                Console.WriteLine(item);

            // Count
            Console.WriteLine("*** Count ***");
            Console.WriteLine(users.Count);

            // Contains
            Console.WriteLine("*** Contains ***");
            Console.WriteLine(users.ContainsKey("Ayşe"));

            // Remove
            Console.WriteLine("*** Remove ***");
            users.Remove("Ayşe");
            foreach (var item in users)
                Console.WriteLine(item);

            // Keys
            Console.WriteLine("*** Keys ***");
            foreach (var item in users.Keys)
                Console.WriteLine(item);

            // Values
            Console.WriteLine("*** Values ***");
            foreach (var item in users.Values)
                Console.WriteLine(item);

  
        
            

        }

    }
}