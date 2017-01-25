using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TweetStorm
{
    class Program
    {
        static void Main(string[] args)
        {
            Generator gen = new Generator();

            gen.DivideText();

            string[] str = gen.Generate();

            for(int i = 0; i < str.Count(); i++)
            {
                Console.WriteLine(str[i]);
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
