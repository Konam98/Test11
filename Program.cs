using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Unable to create instance for Abstract
            //ClsPdfCreation clsPdfCreation = new ClsPdfCreation();
            AbsDerivedClass abs = new AbsDerivedClass();
            Console.WriteLine(abs.GetFilePath());
            Console.WriteLine(abs.GetFileDetails());
            Console.ReadLine();
        }

    }
}
