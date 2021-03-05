using System;

public class Person {
    public String Name { get;set; }
    public int Age {get;set;}

    public Person() {
        this.Name = "defaut name";
        this.Age = 0;
    }
    public Person(String Name, int Age) {
        this.Name = Name;
        this.Age = Age;
    }

    public void Eat(){
        Console.WriteLine("eat");
    }
    public void Eat(int speed){
        Console.WriteLine("eat at " + speed);
    }
    public void Eat(String food){
        Console.WriteLine("eat " + food);
    }
    public virtual void display() {
        Console.WriteLine("Person Name");
        // Console.WriteLine("Person Name: {0}, Age: {1}." + this.Name, this.Age);
    }

}