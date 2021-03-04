using System;
using System.IO;

namespace project1
{
    class Program
    {
        public static void tinhThue() {
            float thuesuat = 0.1f;

            // int a = Convert.ToInt32(Console.ReadLine());
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Hello World C#!" + a);
            if (a > 500) {
                float thue = a*thuesuat;
                Console.WriteLine("So tien thue phai nop: " + thue);
            } else {
                Console.WriteLine("Ban khong phai nop thue");
            }
        }

        public static void xepLoai() {
            Console.WriteLine("Nhap vao diem");
            int diem = Convert.ToInt32(Console.ReadLine());
            if (diem > 100) {
                Console.WriteLine("Khong hop le");
            } else if (diem > 80 && diem <=100) {
                Console.WriteLine("Xep loai gioi");
            } else if (diem > 70) {
                Console.WriteLine("Xep loai kha");
            } else if (diem > 60) {
                Console.WriteLine("Xep loai TB kha");
            } else if (diem > 50) {
                Console.WriteLine("Xep loai TB");
            } else {
                Console.WriteLine("Xep loai yeu");
            }
        }
        public static void tinhTienDien() {
            Console.WriteLine("Nhap vao sodien");
            int soDien = Convert.ToInt32(Console.ReadLine());
            float giaDien = 0f;
            if (soDien <= 100) {
                Console.WriteLine("giaDien 1");
                giaDien = 450; 
            } else if (giaDien <= 200) {
                giaDien = 600; 
            } else if (giaDien <= 300) {
                giaDien = 750; 
            } else if (giaDien <= 500) {
                giaDien = 900; 
            } else if (giaDien <= 1000) {
                giaDien = 1000; 
            } else {
                giaDien = 1200; 
            }
            float tienDien = soDien*giaDien;
            float thueSuat = 0.1f;
            float tienDienSauThue = tienDien*(1+ thueSuat); 
            Console.WriteLine("Gia dien : " + giaDien);
            Console.WriteLine("Tien dien: " + tienDien + " ,tien dien sau thue : " + tienDienSauThue);
        }

        public static void DemoTextWriter(){
            Console.WriteLine("Enter file name");
            String fileName = Console.ReadLine();
            StreamWriter writer = File.AppendText(fileName);
            Console.WriteLine("Nhap du lieu");

            String content = Console.ReadLine();
            writer.WriteLine(content);
            writer.Close();
        }

        public static void DemoTextReader(){
            Console.WriteLine("Enter file name");
            String fileName = Console.ReadLine();

            if (!File.Exists(fileName)) {
                Console.WriteLine("File khong ton tai");
                return;
            }
            StreamReader reader = File.OpenText(fileName);
            String input;
            while ((input = reader.ReadLine()) != null) {
                Console.WriteLine(input);
            }
            reader.Close();
        }
        public static void DemoTextReader1(){
            Console.WriteLine("Enter file name");
            String fileName = Console.ReadLine();

            if (!File.Exists(fileName)) {
                Console.WriteLine("File khong ton tai");
                return;
            }
            StreamReader reader = File.OpenText(fileName);
            String input;
            do {
                input = reader.ReadLine();
                Console.WriteLine(input);
                System.Threading.Thread.Sleep(1000);
            } while (input != null);
            reader.Close();
        }
        public static void DemoTextReader2(){
            Console.WriteLine("Enter file name");
            String fileName = Console.ReadLine();
            String input;

            try {
                StreamReader reader = File.OpenText(fileName);
                do {
                    input = reader.ReadLine();
                    Console.WriteLine(input);
                    System.Threading.Thread.Sleep(1000);
                } while (input != null);
                reader.Close();
                
            } catch (Exception e)  {
                Console.WriteLine("File khong ton tai");
                Console.WriteLine("Exception e: " + e);
            }
        }

        public static void XuLyException() {
            try {
                Console.WriteLine("Moi ban nhap so chia:");
                int soChia = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Moi ban nhap so bi chia:");
                int soBiChia = Convert.ToInt32(Console.ReadLine());
                int KetQua = soChia/soBiChia;
                Console.WriteLine("Ket qua la: " + KetQua);
            } catch (DivideByZeroException dbze) {
                Console.WriteLine("Error DivideByZero : " + dbze);
            } catch (Exception e) {
                Console.WriteLine("Co loi: " + e);
            }
        }
        // public static void TinhTong100SoDauTien() {
        //     for (int i=0;i++1;if<)
        // }
        public static int tinhDienTichHinhChuNhat() {
            Console.WriteLine("Moi ban nhap chieu dai:");
            int h = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Moi ban nhap chieu rong:");
            int w = Convert.ToInt32(Console.ReadLine());
            int KetQua = h*w;
            return KetQua;
        }
        public static void TinhDienTichApp() {
            Console.WriteLine("Chon mot tinh nang!");
            Console.WriteLine("1. Tinh dien tich hinh vuong");
            Console.WriteLine("2. Tinh dien tich hinh chu nhat");
            Console.WriteLine("3. Tinh dien tich hinh tam giac");
            Console.WriteLine("4. Tinh dien tich hinh tron");
            Console.WriteLine("5. Thoat.");
            int function = Convert.ToInt32(Console.ReadLine());
            int dt = 0;
            switch (function) {
                case 1:
                    dt = tinhDienTichHinhChuNhat();
                    break;
                case 2:
                    dt = tinhDienTichHinhChuNhat();
                    break;
                case 3:
                    dt = tinhDienTichHinhChuNhat();
                    break;
                case 4:
                    dt = tinhDienTichHinhChuNhat();
                    break;
                default:
                    return;
            }
            Console.WriteLine("dt : " + dt);
        }


        static void Main(string[] args)
        {
            // tinhThue();
            // xepLoai();
            // tinhTienDien();
            // DemoTextWriter();
            // DemoTextReader();
            // DemoTextReader1();
            // DemoTextReader2();
            // XuLyException();
            do {
                TinhDienTichApp();
            } while (true);
        }
    }
}
