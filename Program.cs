using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B0226497_段昱如_PDPR__Week6_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("B0226497_段昱如_PDPR__Week6_6");
            Console.WriteLine("num1 = 4321987, num2 = -4321987, num3 = 4321.987, num4 = -4321.987");
            Console.WriteLine("num1的D9, num2的d3格式分別為 :num1 = {0,0:D9},num2 = {1,0:d3}", 4321987, -4321987);
            Console.WriteLine("num3的C, num4的c3 格式分別為:num3 = {0,0:C},num4 = {1,0:c3}", 4321.987, -4321.987);
            Console.WriteLine("num3的E, num4的e2 格式分別為 :num3 = {0,0:E},num4 = {1,0:e2}", 4321.987, -4321.987);
            Console.WriteLine("num3的F1, num4的f 格式分別為:num3 = {0,0:F1},num4 = {1,0:f}", 4321.987, -4321.987);
            Console.WriteLine("num3的N3, num4的n 格式分別為 :num3 = {0,0:N3},num4 = {1,0:n}", 4321.987, -4321.987);
            Console.ReadLine();
        }
    }
}
