using System;
using System.Linq;
using System.Collections;

namespace project5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Employee e1 = Employee.setPros();
            // Employee e2 = Employee.setPros();
            Employee e1 = new Employee("cuongvm12", 25, 6);
            e1.loiChao();
            Employee e2 = new Employee("thonglt4", 26, 10);
            e2.loiChao();
            Employee[] es = {e1, e2};
            int maxDs = 0; 
            Employee MDSe = es[0];
            foreach (Employee e in es) {
                if (e.DoanhSo > maxDs) {
                    maxDs = e.DoanhSo;
                    MDSe = e;
                }
            }
            // Employee MDSe = es.Max(x => x.DoanhSo);
            Console.WriteLine("Nhan vien co danh so lon nhat : " + MDSe.Name);
            Employee[] NhanVienCoLuongLonHon2000 = es.Where(x => x.DoanhSo > 2).ToArray();
            Console.WriteLine("So Nhan vien co danh so lon hon 2000 : " + NhanVienCoLuongLonHon2000.Length);

            
        }
    }
}
