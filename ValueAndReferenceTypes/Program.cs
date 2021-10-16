using System;

namespace ValueAndReferenceTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int number1 = 10;
            int number2 = 20;
            number1 = number2;
            number2 = 50;
            Console.WriteLine("Değer Tipi => " + number1); //20

            int[] numbers1 = new int[] { 10, 20, 30};
            int[] numbers2 = new int[] { 100, 200, 300 };
            numbers1 = numbers2;
            numbers2[0] = 999;
            Console.WriteLine("Referans Tipi => " + numbers2[0]); //999
        }
    }
}
