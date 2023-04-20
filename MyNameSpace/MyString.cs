using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNameSpace
{
    internal class MyString
    {
        public String Reverse(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public string[] Split(string str,char delimiter)
        {
            return str.Split(delimiter);
        }
       
            
        
    }
}
