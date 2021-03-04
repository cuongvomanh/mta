using System;
using System.Collections;
using System.Linq;

namespace project2
{
    class Program
    {
        static void b1(){
            Employee e = new Employee("cuongvm12", 25, 100);
            Console.WriteLine("BasicSalary: " + e.CaculateSalary());
            Console.WriteLine("BasicSalary and bonus and punishment: " + e.CaculateSalary(10,20));
            Console.WriteLine("BasicSalary and bonus and punishment and extra: " + e.CaculateSalary(10,20,30));
        }
        static void b2(){
            Student st1 = new Student("cuongvm12", 25, 1, "my dinh");
            Student st2 = new Student("cuongvm12", 25, 1, "my dinh");
            st1.display();
            st2.display();
        }
        static void b3(){
            Student st1 = Student.setPros();
            Student st2 = Student.setPros();
            st1.display();
            st2.display();
        }

        static void b4(){
            Student st1 = new Student("cuongvm12", 25, 1, "my dinh");
            Student st2 = new Student("girl", 26, 2, "my dinh2");
            // Student st1 = Student.setPros();
            // Student st2 = Student.setPros();
            st1.display();
            st2.display();
            ArrayList students = new ArrayList();
            students.Add(st1);
            students.Add(st2);

            int maxAge = 0;
            foreach (Student e in students) {
                if (e.Age > maxAge) {
                    maxAge = e.Age;
                }
            }
            Console.WriteLine("Max Age : " + maxAge);
            Student[] sts = (Student[]) students.ToArray(typeof(Student));
            Student[] chanIdsts = sts.Where(x => x.Id %2 ==0).ToArray();
            Console.WriteLine("So sv Id chan : " + chanIdsts.Length);
            

            // Enumerable.Range(1, 10).Select(x => x + 2);

            

        }

        static void b5(){
            Person em = new Employee("em", 25, 100);
            Person dc = new Doctor("dc", 37);
            em.display();
            dc.display();
        }
        static void b6(){
            Student st1 = new Student("cuongvm12", 25, 1, "my dinh");
            st1.di();
            st1.di(12);
        }

        static void Main(string[] args)
        {
            b6();
        }
    }
}
