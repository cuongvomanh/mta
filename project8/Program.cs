using System;

namespace project8
{
    class Program
    {
        public static int tinhChuViHinhThang(){
            Console.WriteLine("Moi ban nhap day tren:");
            int dt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Moi ban nhap day duoi:");
            int dd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Moi ban nhap canh trai:");
            int ct = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Moi ban nhap canh phai:");
            int cp = Convert.ToInt32(Console.ReadLine());
            int KetQua = dt + dd + ct + cp;
            return KetQua;
        }
        public static int tinhChuViHinhBinhHanh(){
            Console.WriteLine("Moi ban nhap canh dai:");
            int ct = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Moi ban nhap canh ngan:");
            int cp = Convert.ToInt32(Console.ReadLine());
            int KetQua = (ct+cp)*2;
            return KetQua;
        }
        public static int tinhChuViHinhThoi(){
            Console.WriteLine("Moi ban nhap canh:");
            int ct = Convert.ToInt32(Console.ReadLine());
            int KetQua = ct*4;
            return KetQua;
        }
        public static int tinhDienTich(int dt, int dd, int h){
            int KetQua = h*(dt+dd)/2;
            return KetQua;
        }
        public static int tinhDienTichHinhThang() {
            Console.WriteLine("Moi ban nhap day tren:");
            int dt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Moi ban nhap day duoi:");
            int dd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Moi ban nhap chieu cao");
            int h = Convert.ToInt32(Console.ReadLine());
            int KetQua = tinhDienTich(dt,dd,h);
            return KetQua;
        }
        public static int tinhDienTichHinhBinhHanh() {
            Console.WriteLine("Moi ban nhap day:");
            int dt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Moi ban nhap chieu cao");
            int h = Convert.ToInt32(Console.ReadLine());
            int KetQua = tinhDienTich(dt,dt,h);
            return KetQua;
        }
        public static int tinhDienTichHinhThoi() {
            return tinhDienTichHinhBinhHanh();
        }
        public static void TinhChuViDienTichApp() {
            Console.WriteLine("Chon mot tinh nang!");
            Console.WriteLine("1. Tinh chu vi va dien tich hinh thang");
            Console.WriteLine("2. Tinh chu vi va dien tich hinh binh hanh");
            Console.WriteLine("3. Tinh chu vi va dien tich hinh thoi");
            Console.WriteLine("4. Tinh chu vi va dien tich hinh tru");
            Console.WriteLine("5. Thoat.");
            int function = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1. Tinh Dien tich");
            Console.WriteLine("2. Tinh chu vi");
            int dt = 0;
            int function1 = Convert.ToInt32(Console.ReadLine());
            switch (function) {
                case 1:
                    if (function1==1) {
                        dt = tinhDienTichHinhThang();
                        break;
                    } else {
                        dt = tinhChuViHinhThang();
                    }
                    break;
                case 2:
                    if (function1==1) {
                        dt = tinhDienTichHinhBinhHanh();
                        break;
                    } else {
                        dt = tinhChuViHinhBinhHanh();
                    }
                    break;
                case 3:
                    if (function1==1) {
                        dt = tinhDienTichHinhThoi();
                        break;
                    } else {
                        dt = tinhChuViHinhThoi();
                    }
                    break;
                case 4:
                    if (function1==1) {
                        dt = tinhDienTichHinhThang();
                        break;
                    } else {
                        dt = tinhDienTichHinhThang();
                    }
                    break;
                default:
                    throw new Exception("Parameter cannot be null");
            }
            Console.WriteLine("dt : " + dt);
        }
        static void Main(string[] args)
        {
            try {
                while (true)
                {
                    TinhChuViDienTichApp();
                }
            } catch (Exception e){
                Console.WriteLine("Bye");
            }
        }
    }
}
