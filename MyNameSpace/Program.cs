using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNameSpace
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyMaths mathObj = new MyMaths();
            int Add = mathObj.add(4, 5);
            int Subs = mathObj.Subs(8, 2);
            int Mul = mathObj.Mul(4, 5);
            Console.WriteLine(Add);
            Console.WriteLine(Subs);
            Console.WriteLine(Mul);
            Console.ReadLine();

           MyString str = new MyString();
            string reversed = str.Reverse("hello sir");
            string[] split = str.Split("hello,world", ',');
            Console.WriteLine("Reversed string is:"+reversed);
            Console.WriteLine("Split string:");
            foreach (string s in split)
                Console.WriteLine(s);
                Console.ReadLine();


        }
        
    }
}
