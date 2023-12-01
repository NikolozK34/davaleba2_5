using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace davaleba2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("sheiyvane ricxvi: ");

            int n = int.Parse(Console.ReadLine());

            if(n == 1) 
            {
                Console.WriteLine("orshabati");
            }else if(n == 2)
            {
                Console.WriteLine("samshabati");
            }else if (n == 3)
            {
                Console.WriteLine("otxshabati");
            }
            else if(n == 4)
            {
                Console.WriteLine("xutshabati");
            }else if( n == 5)
            {
                Console.WriteLine("paraskevi");
            }else if( n == 6)
            {
                Console.WriteLine("shabati");
            }else if(n == 7)
            {
                Console.WriteLine("kvira");
            }
            else
            {
                Console.WriteLine("wrong input");
            }
        }
    }
}
