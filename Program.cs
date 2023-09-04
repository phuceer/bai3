using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nSo1, nSo2, ntong = 0;
            Console.Clear();
            Console.Write("{0}", "nhap so thu nhat :");
            nSo1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("{0}", "nhap so thu hai :");
            nSo2 = Convert.ToInt32(Console.ReadLine()); 
            ntong = nSo1 + nSo2;
            Console.WriteLine("tong cua" + nSo1 + "va" + nSo2 + "la" + ntong);
            Console.ReadKey(); 
        }
    }
}

