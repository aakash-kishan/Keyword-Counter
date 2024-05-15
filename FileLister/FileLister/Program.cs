using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileLister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileDisplay fd = new FileDisplay();
            fd.Paths = "C:\\Users\\DELL\\source\\repos\\FileLister\\FileLister\\testfiles\\";
            fd.Display();
            ;

        }
    }
}
