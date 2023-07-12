using System;



namespace hazir_metotlar_string
{
    class Program
    {
        static void Main(string[] args)
        {

            
            string degisken = "Dersimiz CSharp, Hoşgeldiniz!";
            string degisken1 = "dersimiz CSharp, Hoşgeldiniz!";


            //Length
            Console.WriteLine("**********Length**********");
            Console.WriteLine("Length: " + degisken.Length);

            //ToUpper, ToLower
            Console.WriteLine("**********ToUpper, ToLower**********");
            Console.WriteLine("ToUpper: " + degisken.ToUpper());
            Console.WriteLine("ToLower: " + degisken.ToLower());

            //Concat
            Console.WriteLine(String.Concat(degisken, " Merhaba!"));

            //Compare, CompareTo
            Console.WriteLine("**********Compare, CompareTo**********");
            Console.WriteLine(degisken.CompareTo(degisken1)); //0,1,-1
            Console.WriteLine(String.Compare(degisken, degisken1, true));
            Console.WriteLine(String.Compare(degisken, degisken1, false));

            //Contains
            Console.WriteLine("**********Contains**********");
            Console.WriteLine(degisken.Contains(degisken1));
            Console.WriteLine(degisken.EndsWith("Hoşgeldiniz!"));
            Console.WriteLine(degisken.StartsWith("Merhaba!"));

            //IndexOf
            Console.WriteLine("**********IndexOf**********");
            Console.WriteLine(degisken.IndexOf("CS"));
            Console.WriteLine(degisken.IndexOf("Java"));
            Console.WriteLine(degisken.LastIndexOf("i"));

            //Insert
            Console.WriteLine("**********Insert**********");
            Console.WriteLine(degisken.Insert(0, "Merhaba! "));

            //PadLeft, PadRight
            Console.WriteLine("**********PadLeft, PadRight**********");
            Console.WriteLine(degisken + degisken1.PadLeft(30));
            Console.WriteLine(degisken + degisken1.PadLeft(30, '*'));
            Console.WriteLine(degisken.PadRight(50) + degisken1);
            Console.WriteLine(degisken.PadRight(50, '-') + degisken1);

            //Remove
            Console.WriteLine("**********Remove**********");
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(5, 3));
            Console.WriteLine(degisken.Remove(0, 1));

            //Replace
            Console.WriteLine("**********Replace**********");
            Console.WriteLine(degisken.Replace("CSharp", "C#"));
            Console.WriteLine(degisken.Replace(" ", "*"));

            //Split
            Console.WriteLine("**********Split**********");
            Console.WriteLine(degisken.Split(' ')[1]);

            //Substring
            Console.WriteLine("**********Substring**********");
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4, 6));

            //Trim
            Console.WriteLine("**********Trim**********");
            Console.WriteLine(degisken.Trim());
            Console.WriteLine(degisken.TrimStart());
            Console.WriteLine(degisken.TrimEnd());

            Console.ReadLine();

    
        }

    }
}