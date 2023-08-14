using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoBaiTap3
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            while (true)
            {
                DanhSachChucNang();
                int n = int.Parse(Console.ReadLine());
                switch (n)
                {
                    case 1:
                        BaiTap1();
                        break;
                    case 2:
                        BaiTap2();
                        break;
                    case 3:
                        BaiTap3();
                        break;
                    case 4:
                        BaiTap4();
                        break;
                    case 5:
                        BaiTap5();
                        break;
                    case 6:
                        BaiTap6();
                        break;
                    case 7:
                        BaiTap7();
                        break;
                    case 8:
                        BaiTap8();
                        break;
                    case 9:
                        BaiTap9();
                        break;
                    case 10:
                        BaiTap10();
                        break;
                }
                bool stop = DungChuongTrinh();
                if (stop) break;
            }
        }
        private static void DanhSachChucNang()
        {
            Console.WriteLine("1. Bai tap 1");
            Console.WriteLine("2. Bai tap 2");
            Console.WriteLine("3. Bai tap 3");
            Console.WriteLine("4. Bai tap 4");
            Console.WriteLine("5. Bai tap 5");
            Console.WriteLine("6. Bai tap 6");
            Console.WriteLine("7. Bai tap 7");
            Console.WriteLine("8. Bai tap 8");
            Console.WriteLine("9. Bai tap 9");
            Console.WriteLine("10. Bai tap 10");
            Console.WriteLine("--------------");
            Console.Write("Moi ban chon bai tap: ");
        }
        private static bool DungChuongTrinh()
        {
            Console.WriteLine();
            Console.WriteLine("Ban co muon dung chuong trinh?");
            Console.WriteLine("Phim bat ky de tiep tuc!");
            Console.WriteLine("ESC. De thoat chuong trinh");
            ConsoleKeyInfo str = Console.ReadKey();
            if (str.Key == ConsoleKey.Escape) return true;
            Console.Clear();
            return false;
        }

        private static void BaiTap1()
        {
            Console.Write("Nhap vao so nguyen n = ");
            int n = int.Parse(Console.ReadLine());
            if (n % 3 == 0)
            {
                Console.WriteLine("So {0} chia het cho 3", n);
            }
            else
            {
                Console.WriteLine("So {0} khong chia het cho 3", n);
            }
        }
        private static void BaiTap2()
        {
            Console.Write("Nhap vao so nguyen n = ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Bang cuu chuong {0}", i);
                for (int j = 1; j <= 10; j++)
                {
                    int s = i * j;
                    Console.WriteLine("{0} x {1} = {2}", i, j, s);
                }
                Console.WriteLine();
            }
        }
        private static void BaiTap3()
        {
            Console.Write("Nhap vao so nguyen n = ");
            int n = int.Parse(Console.ReadLine());
            int s = 0;
            for (int i = 1; i <= n; i++) s += i;
            Console.WriteLine("Tong tu 1 den {0} la {1}", n, s);
            Console.WriteLine();
        }
        private static void BaiTap4()
        {
            Console.Write("Nhap vao so nguyen n = ");
            int n = int.Parse(Console.ReadLine());

            if (Math.Sqrt(n) % 1 == 0)
            {
                Console.WriteLine("{0} la so chinh phuong", n);
            }
            else
            {
                Console.WriteLine("{0} khong la so chinh phuong", n);
            }
            Console.WriteLine();
        }
        private static void BaiTap5()
        {
            Console.Write("Nhap vao so nguyen n = ");
            int n = int.Parse(Console.ReadLine());

            if (n >= 1 && n <= 12)
            {
                Console.WriteLine("Thang {0} co {1} ngay", n, DateTime.DaysInMonth(DateTime.Now.Year, n));
            }
            else
            {
                Console.WriteLine("Thang khong hop le");
            }
            Console.WriteLine();
        }
        private static void BaiTap6()
        {
            Console.Write("Nhap vao so nguyen n = ");
            int n = int.Parse(Console.ReadLine());

            int s = 0;
            for (int i = 1; i <= n; i++) s += (int)Math.Pow(i, i);
            Console.WriteLine("Tong cac so theo cong thuc la {0}", s);
            Console.WriteLine();
        }
        private static void BaiTap7()
        {
            Console.Write("Nhap vao so nguyen n = ");
            int n = int.Parse(Console.ReadLine());

            int s = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 != 0) s += i;
            }
            Console.WriteLine("Tong cac so le tu 1 den {0} la {1}", n, s);
            Console.WriteLine();
        }
        private static void BaiTap8()
        {
            Console.Write("Nhap vao so nguyen n = ");
            int n = int.Parse(Console.ReadLine());

            int bien_dem = 0;
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    bien_dem++;
                    Console.WriteLine("So {0} khong la so nguyen to", n);
                    break;
                }
            }
            if (bien_dem == 0 && n != 1)
            {
                Console.WriteLine("So {0} la so nguyen to", n);
            }
            Console.WriteLine();
        }
        private static void BaiTap9()
        {
            Console.Write("Nhap vao so nguyen n = ");
            int n = int.Parse(Console.ReadLine());

            string str = "";
            for (int i = 0; i < n; i++)
            {
                str = String.Concat(str, "*");
                Console.WriteLine(str);
            }
            Console.WriteLine();
        }
        private static void BaiTap10()
        {
            Console.Write("Nhap vao so nguyen n = ");
            int n = int.Parse(Console.ReadLine());

            int f0 = 0;
            int f1 = 1;
            int fN;
            Console.WriteLine("Day Fibonacci voi {0} phan tu la: {0}", n);

            if (n < 0)
            {
                Console.WriteLine("Khong hop le");
            }
            else if (n == 1)
            {
                Console.WriteLine(f0);
            }
            else if (n == 2)
            {
                Console.WriteLine("{0}  {1}", f0, f1);
            }
            else
            {
                Console.Write("{0}  {1}", f0, f1);
                for (int i = 2; i < n; i++)
                {
                    fN = f0 + f1;
                    Console.Write("  {0}", fN);
                    f0 = f1;
                    f1 = fN;
                }
            }
            Console.WriteLine();
        }
    }
}
