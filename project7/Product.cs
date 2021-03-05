using System;
public class Product{
    public String Name{set;get;}
    public int Id{set;get;}
    public Product(String Name, int Id) {
        this.Name = Name;
        this.Id = Id;
    }
    public static Product setPros (){
        Console.WriteLine("Nhap name");
        String Name = Console.ReadLine();
        Console.WriteLine("Nhap Id");
        int Id = Convert.ToInt32(Console.ReadLine());
        Product e = new Product(Name, Id);
        return e;
    }
}