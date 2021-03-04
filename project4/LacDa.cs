using System;
public sealed class LacDa : Animal, DongVatAnThit {
    public const int age = 10;
    public void run(){

    }
    public override void eat()
    {
        Console.WriteLine("Lacda eat");
        
    }
    public override void drink()
    {
        Console.WriteLine("Lacda drink");
        
    }
    public void sanmoi()
    {
        Console.WriteLine("Person sanmoi");
    }

}


