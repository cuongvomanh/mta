using System;
public class Employee : Person {
    private int BasicSalary {get;set;}
    public Employee(String Name, int Age, int BasicSalary) : base(Name, Age) {
        this.BasicSalary = BasicSalary;
    }
    public int CaculateSalary(){
        return this.BasicSalary;
    }

    public int CaculateSalary(int bonus, int punishment) {
        return this.BasicSalary + bonus - punishment;
    }
    public int CaculateSalary(int bonus, int punishment, int extra) {
        return this.CaculateSalary(bonus, punishment) + extra;
    }
}