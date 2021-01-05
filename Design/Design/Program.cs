using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Design In-Memory File System
            DesignInMemoryFileSystem mem = new DesignInMemoryFileSystem();
            var res = mem.Ls("/");
            mem.Mkdir("/a/b/c");
            mem.AddContentToFile("/a/b/c/d", "hello");
            var res1 = mem.Ls("/");
            var str =  mem.ReadContentFromFile("/a/b/c/d");
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
