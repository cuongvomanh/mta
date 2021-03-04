using System;
public class Person : Animal, DongVatAnThit {
    public override void eat()
    {
        Console.WriteLine("Person eat");
        
    }
    public override void drink()
    {
        Console.WriteLine("Person drink");
    }
    public void sanmoi()
    {
        Console.WriteLine("Person sanmoi");
    }

}