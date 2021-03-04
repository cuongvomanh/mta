using System;
public class Doctor : Person {
    public Doctor() : base(){
    }
    public Doctor(String Name, int Age) : base(Name, Age){
    }
    public override void display(){
        Console.WriteLine("Doctor Name: {0}, Age: {1}", base.Name, base.Age);
    }
}