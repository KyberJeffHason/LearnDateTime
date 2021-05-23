using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tut_c
{
    class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now; // текущая дата.
            var nowutc = DateTime.UtcNow; // текущая дата в формате UTC.
            Console.WriteLine(now);
        }
    }
}
