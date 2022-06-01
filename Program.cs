using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using ConfigBuildersTester.Properties;

namespace ConfigBuildersTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Hello, {Settings.Default.Who}");
            Console.ReadLine();
        }
    }
}
