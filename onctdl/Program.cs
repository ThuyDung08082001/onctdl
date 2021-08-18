using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onctdl
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Person ps = new Person("dung", new DateTime(2001 / 8 / 8), "nu", "sinh vien");
            Person ps1 = new Person("an", new DateTime(2001 / 5 / 25), "nam", "giam doc");
            Person ps2 = new Person("ly", new DateTime(2001 / 8 / 8), "nu", "sinh vien");
            Person ps3 = new Person("kieu", new DateTime(1999 / 9 / 16), "nam", "nhan vien");

            Console.WriteLine(ps.toString());

            
        }
       
        
    }
}
