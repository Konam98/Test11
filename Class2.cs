using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class AbsDerivedClass : ClsPdfCreation
    {
        public override string GetFilePath()
        {
            string filePath = @"C:\demo\testfile.txt";
            return filePath;
        }

        public override string GetFileDetails()
        {
            string fileContant = "this is after the virtual override";
            return fileContant;
        }
    }

}
