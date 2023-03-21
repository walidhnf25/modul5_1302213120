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
            // soal 1
            Penjumlahan penjumlahan= new Penjumlahan();
            Console.WriteLine(penjumlahan.JumlahTigaAngka<long>(13, 2, 21));

            //soal2
            SimpleDataBase<long> db = new SimpleDataBase<long>();
            db.AddNewData(13);
            db.AddNewData(2);
            db.AddNewData(21);

            db.PrintAllData();
        }
    }

    public class Penjumlahan
    {
        public T JumlahTigaAngka<T>( T lhs,  T rhs, T xhs)
        {
            //soal 1
            return (dynamic)lhs+(dynamic)rhs+(dynamic)xhs;

        }
    }

    public class SimpleDataBase<T>
    {
        private List<T> storedData;
        private List<DateTime> inputDates;

        public SimpleDataBase()
        {
            storedData = new List<T>();
            inputDates = new List<DateTime>();
        }

        public void AddNewData(T data)
        {
            storedData.Add(data);
            inputDates.Add(DateTime.UtcNow);
        }

        public void PrintAllData()
        {
            for (int i = 0; i < storedData.Count; i++)
            {
                Console.WriteLine($"Data {i + 1} berisi: {storedData[i]}, yang disimpan pada waktu UTC: {inputDates[i]}");
            }
        }
    }
}