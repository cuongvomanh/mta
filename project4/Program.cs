using System;

namespace project4
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal person = new Person();
            person.eat();
            person.drink();
            DongVatAnThit dongVatAnThit = person as DongVatAnThit;
            dongVatAnThit.sanmoi();

            Lion lion1 = new Lion();
            Console.WriteLine("Lion Age1 " + Lion.age);
            Lion lion2 = new Lion();
            Lion lion3 = new Lion();

        }
    }
}
