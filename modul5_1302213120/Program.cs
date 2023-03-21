using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace modul5_1302213120
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Penjumlahan penjumlahan= new Penjumlahan();
            Console.WriteLine(penjumlahan.JumlahTigaAngka<long>(13, 2, 21));
        }
    }

    public class Penjumlahan
    {
        public T JumlahTigaAngka<T>( T lhs,  T rhs, T xhs)
        {
            return (dynamic)lhs+(dynamic)rhs+(dynamic)xhs;

        }
    }
}