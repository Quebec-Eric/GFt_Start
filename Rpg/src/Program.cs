using System;
using src.Entities;


namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {

            Knight arus = new Knight("Arus", 42,"Knight", 469,749,72,72);
           Console.WriteLine(arus);
           Console.WriteLine(arus.Attack(7));

           Ninja Wedge= new Ninja("Wedge",42,"Ninja",292,574,89,89);
            Console.WriteLine(Wedge);
           Console.WriteLine(Wedge.Attack(7));
           Console.WriteLine(Wedge.Attack(1));


           
           
        }
    }
}