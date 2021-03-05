using System;
public class Employee : Person{
    public int DoanhSo{set;get;}
    public Employee(String Name, int Age, int DoanhSo) : base(Name, Age) {
        this.DoanhSo = DoanhSo;
    }
    public void loiChao(){
        if (DoanhSo > 10 || DoanhSo < 0) {
            Console.WriteLine("Khong hop le");
        } else if (DoanhSo >= 8) {
            Console.WriteLine("Tuyet voi");
        } else if (DoanhSo >= 7) {
            Console.WriteLine("Rat tot");
        } else if (DoanhSo >= 6) {
            Console.WriteLine("Tot");
        } else if (DoanhSo >= 5) {
            Console.WriteLine("Co co gang");
        } else if (DoanhSo >= 4) {
            Console.WriteLine("Kem");
        } else {
            Console.WriteLine("Rat Kem");
        }
    }
    public static Employee setPros (){
        Console.WriteLine("Nhap name");
        String Name = Console.ReadLine();
        Console.WriteLine("Nhap age");
        int Age = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Nhap DoanhSo");
        int DoanhSo = Convert.ToInt32(Console.ReadLine());
        Employee e = new Employee(Name, Age, DoanhSo);
        return e;
    }

}