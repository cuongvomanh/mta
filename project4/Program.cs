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
            Lion.vomoi();
            Console.WriteLine("Lion Age1 " + Lion.age);
            Lion.age = Lion.age + 1;
            Console.WriteLine("Lion Age2 " + Lion.age);

        }
    }
}
