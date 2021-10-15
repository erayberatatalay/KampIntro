using System;
using System.Collections.Generic;
using System.Text;

namespace Mathematics
{
    class FourTransactions
    {
        //Topla
        public void gather(int number1, int number2)
        {
            int total = number1 + number2;
            Console.WriteLine("Result : " + total);
        }
        //Çıkar
        public void interest(int number1, int number2)
        {
            int total = number1 - number2;
        }
        //Çarp
        public void multiply(int number1, int number2)
        {
            int total = number1 * number2;
        }
        //Böl
        public void plenty(int number1, int number2)
        {
            int total = number1 / number2;
        }
    }
}
