using System;
namespace USDtoVND{
    class Program{
        static void Main(string[] args){
            float USD; 
            float VND;
            const int rate=23000;
            Console.WriteLine("Type USD: "); 
            USD = float.Parse(Console.ReadLine());
            VND = USD * rate;
            Console.WriteLine("to VND = "+ VND+"đ");

        }
    }
}
