using System;
public class Lion : Animal, DongVatAnThit {
    public static int age;
    public static void vomoi(){
        Console.WriteLine("Lion vomoi");
    }
    public override void eat()
    {
        Console.WriteLine("Lion eat");
        
    }
    public override void drink()
    {
        Console.WriteLine("Lion drink");
        
    }
    public void sanmoi()
    {
        Console.WriteLine("Person sanmoi");
    }

}

