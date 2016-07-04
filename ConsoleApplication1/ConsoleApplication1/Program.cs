using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class MainClass
    {
        static void Main()
        {
            string temp;
            int price;

            Console.Write("価格を入力してください>>>");
            temp = Console.ReadLine();
            price = Int32.Parse(temp);

            Console.WriteLine("税込み{0:c}", price * 1.08);
        }
    }
}
