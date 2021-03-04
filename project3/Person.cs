using System;

public abstract class Person {
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

    public abstract void go();
    public abstract void run();

}