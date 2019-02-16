using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyParser
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLanguageParser parser = new MyLanguageParser();
            do
            {
                var cmd=Console.ReadLine();
                parser.Parse(cmd);

            } while (true);

        }
    }
}
