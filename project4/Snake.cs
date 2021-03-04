using System;
public class Snake : Animal, DongVatAnThit {

    public override void eat()
    {
        Console.WriteLine("Snake eat");
        
    }
    public override void drink()
    {
        Console.WriteLine("Snake drink");
        
    }
    public void sanmoi()
    {
        Console.WriteLine("Person sanmoi");
    }
}
