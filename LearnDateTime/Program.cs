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
            var now = DateTime.Now; // Current date.
            var nowutc = DateTime.UtcNow; // Current date in UTC format.
            Console.WriteLine(now);
            Console.WriteLine(nowutc);

            var date = new DateTime(2021, 05, 23, 17, 27, 1); // Creating date from this info: 2021 year, 05 month, 23 day, 17 hour, 27 minute, 1 second.
            Console.WriteLine(date);

            var usaDate1 = "05-23-2021";
            var usaDate2 = "05/24/2021";
            var dateString = "202105";
            DateTime date3;


            var usaDate1_d = DateTime.ParseExact(usaDate1, "MM-dd-yyyy", null);
            Console.WriteLine($"USA FIRST DATE Converted: {usaDate1_d}, from {usaDate1} ");
            var usaDate2_d = DateTime.ParseExact(usaDate2, "MM/dd/yyyy", null);
            Console.WriteLine($"USA SECOND DATE Converted: {usaDate2_d}, from {usaDate2} ");

            var foo = DateTime.Compare(usaDate1_d, usaDate2_d); // -1 means earlier, 0 means the same, 1 means later
            Console.WriteLine($"Comparing number: {foo}");

            if (DateTime.TryParseExact(dateString, "yyyyMM", null, System.Globalization.DateTimeStyles.None, out date3))
            {
                Console.WriteLine($"Conversion was succesful, date {date3}");
            }
            else
            {
                Console.WriteLine("Conversion failed");
            }

            var difference = usaDate2_d - usaDate1_d;
            Console.WriteLine(difference); // same as SpanOfDay
            var SpanOfDay = TimeSpan.FromDays(1);
            Console.WriteLine(SpanOfDay); // same as difference

            Console.WriteLine(usaDate2_d - TimeSpan.FromDays(5)); // usaDate2_d - 5 days.

        }
    }
}
