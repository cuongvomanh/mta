using System;
public class Student : Person {
    public int Id {set;get;}
    public String Address{set;get;}
    public Student (String Name, int Age, int Id, String Address) : base(Name, Age) {
        this.Id = Id;
        this.Address = Address;
    }
    public override void display() {
        Console.WriteLine("Student id: {0}, Name {1}", this.Id, base.Name);
    }

    public void di(){
        Console.WriteLine("Di");
    }
    public void di(int speed){
        Console.WriteLine("Di at " + speed);
    }
    
    public static Student setPros (){
        Console.WriteLine("Nhap id");
        int Id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap name");
        String Name = Console.ReadLine();
        Console.WriteLine("Nhap age");
        int Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap address");
        String Address = Console.ReadLine();
        Student student = new Student(Name, Age, Id, Address);
        return student;
    }

}