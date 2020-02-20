using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = "hello world";
            Console.WriteLine(data);
            string a = data.Insert(6, "My");
            string bn = "u r nice";


            Console.WriteLine(a);
            Console.WriteLine(String.Concat(a, bn));
            string up = data.ToUpper();
            string lc = up.ToLower();
            Console.WriteLine("substring {0}", bn.Substring(4, 4));
            Console.WriteLine("{0}\t{1}", up, lc);
            string[] names = new string[] { "anand", "raju", "munna" };
            foreach(string st in names)
            {
                Console.WriteLine(st);
            }
            string allnames = string.Join(",", names);
            Console.WriteLine(allnames);
            string st1 = "welcome to c#";
            string[] words = st1.Split();
            foreach(string s in words)
            {
                Console.WriteLine(s);
            }

            string nstr = string.Copy(st1);
            Console.WriteLine("copied string is {0}", nstr);
            int i = st1.IndexOf("to");
            Console.WriteLine("index of is {0}", i);

            int l = st1.Length;
            Console.WriteLine("lengh of the string is {0}", l);
            words.Reverse();
            foreach(string w in words)
            {
                Console.WriteLine(w);
            }

            int nx = string.Compare("hello", "world");
            Console.WriteLine("comparison is {0}", nx);






        }
    }
}
