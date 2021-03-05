using System;
using System.Linq;
using System.Collections;

namespace project6
{
    class Program
    {
        public static int[] mang;
        public static void NhapThongTin(){
            Console.WriteLine("Nhap do dai mang");
            int l = Convert.ToInt32(Console.ReadLine());
            mang = new int[l];
            for (int i=0;i<l;i++){
                Console.WriteLine("Nhap " + i);
                int v = Convert.ToInt32(Console.ReadLine());
                mang[i] = v;
            }
            In(mang);
        }
        public static void NhapThongTin1(){
            mang = new int[]{9, 1, 2, 3, 4, 7, 8, 9};
        }
        public static void Sort(){
            // int[] mangSorted = Array.Sort(mang);
            // Array.Sort(mang);
            int[] mangSorted = mang.OrderBy(x => x).ToArray();
            // Console.WriteLine("Mang sorted: " + mangSorted);
            Console.WriteLine("Mang sorted: ");
            In(mangSorted);
        }
        public static void In(int[] m){
            Array.ForEach(m, Console.WriteLine);
        }
        public static void FindMaxMin(){
            Console.WriteLine("Phan tu nho nhat : " + mang.Min());
            Console.WriteLine("Phan tu lon nhat : " + mang.Max());
        }
        public static void Cal(){
            
            int[] mangC = new int[mang.Length/2];
            for(int i=0;i<mang.Length;i++){
                if (i %2==0){
                    mangC.Append(mang[i]);
                }
            }
            int Tong = mangC.Aggregate((x,y)=>x+y);
            Console.WriteLine("Tong mang chan : " + Tong);
            Console.WriteLine("Trung binh cong; " + Tong/mangC.Length);

        }
        public static void FindMaxE(){
            int MaxV = mang.Max();
            int[] mangMax = mang.Where(x=> x==MaxV).ToArray();
            Console.WriteLine("So phan tu lon nhat cua mang: " + mangMax.Length);
        }
        public static void ArrayApp() {
            Console.WriteLine("Chon mot tinh nang!");
            Console.WriteLine("1. Nhap thong tin ve mang");
            Console.WriteLine("2. Sap xep mang");
            Console.WriteLine("3. Hien thong tin ve mang");
            Console.WriteLine("4. In ra phan tu co gia tri nho nhat/lon nhat");
            Console.WriteLine("5. Tinh tong va trung binh cong cua cac phan tu co chi so chan");
            Console.WriteLine("6. In ra so luong cac phan tu trong mang co gia tri lon nhat");
            Console.WriteLine("7. Thoat.");
            int function = Convert.ToInt32(Console.ReadLine());
            switch (function) {
                case 1:
                    NhapThongTin1();
                    break;
                case 2:
                    Sort();
                    break;
                case 3:
                    Console.WriteLine("Mang : ");
                    In(mang);
                    break;
                case 4:
                    FindMaxMin();
                    break;
                case 5:
                    Cal();
                    break;
                case 6:
                    FindMaxE();
                    break;
                default:
                    return;
            }
        }
        static void Main(string[] args)
        {
            while (true) {
                ArrayApp();
            }
        }
    }
}
