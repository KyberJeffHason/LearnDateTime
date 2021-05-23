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
            Console.WriteLine(nowutc);

            var date = new DateTime(2021, 05, 23, 17, 27, 1); // Создание даты по инфе 2021 год, 05 месяц, 23 день, 17 часов,27 минут, 1 секунда 
            Console.WriteLine(date);

            var usaDate1 = "05-23-2021";
            var usaDate2 = "05/23/2021";

            var usaDate1_d = DateTime.ParseExact(usaDate1, "MM-dd-yyyy", null);
            Console.WriteLine($"USA FIRST DATE Converted: {usaDate1_d}, from {usaDate1} ");
            var usaDate2_d = DateTime.ParseExact(usaDate2, "MM/dd/yyyy", null);
            Console.WriteLine($"USA SECOND DATE Converted: {usaDate2_d}, from {usaDate2} ");
        }
    }
}
