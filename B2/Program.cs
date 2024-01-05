using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Chương Trinh May Tinh Mo Phong :");
                Console.WriteLine("1.Tinh Tong");
                Console.WriteLine("2. Tinh hieu");
                Console.WriteLine("3. Tinh tich");
                Console.WriteLine("4. Tinh thương");
                Console.WriteLine("0. Exit");

                Console.Write("Lua chon cua ban (0-4): ");
                string luaChon = Console.ReadLine();

                if (luaChon == "0")
                {
                    Console.WriteLine("Ban da chon exit.");
                    break;
                }

                double soA, soB;
                Console.Write("Enter so T1: ");
                if (!double.TryParse(Console.ReadLine(), out soA))
                {
                    Console.WriteLine("Faild, vui long nhap lai. ");
                    continue;
                }
                Console.Write("Enter so T2 : ");
                if (!double.TryParse(Console.ReadLine(), out soB))
                {
                    Console.WriteLine("Faild, vui long nhap lai.");
                    continue;
                }

                double ketQua = 0;

                switch (luaChon)
                {
                    case "1":
                        ketQua = TinhTong(soA, soB);
                        break;
                    case "2":
                        ketQua = TinhHieu(soA, soB);
                        break;
                    case "3":
                        ketQua = TinhTich(soA, soB);
                        break;
                    case "4":
                        ketQua = TinhThuong(soA, soB);
                        break;
                    default:
                        Console.WriteLine("Faild, vui long nhap lai.");
                        continue;
                }

                Console.WriteLine($"Ket Qua : {ketQua}");
            }

        }
        static double TinhTong(double a, double b)
        {
            return a + b;
        }
        static double TinhHieu(double a, double b)
        {
            return a - b;
        }
        static double TinhTich(double a, double b)
        {
            return a * b;
        }
        static double TinhThuong(double a, double b)
        {
            if (b == 0)
            {
                Console.WriteLine("Khong the chia ");
            }
            return a / b;
        }
    }
}
