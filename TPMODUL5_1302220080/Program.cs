using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPMODUL5_1302220080
{

    class DataGeneric<T>
    {
        T Data { get; set; }
        public DataGeneric(T data)
        {
            Data = data;
        }
        public void PrintData()
        {
            Console.WriteLine($"Data yang tersimpan adalah: {Data}");
        }
    }
    class Program
    {


        static void Main(string[] args)
        {
            DataGeneric<string> stringData = new DataGeneric<string>("Y");
            stringData.PrintData();
            DataGeneric<string> nimData = new DataGeneric<string>("1302220080");
            nimData.PrintData();
            Console.ReadLine();
        }
    }
}