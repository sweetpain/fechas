using System;

namespace fechas
{
    class Program
    {
        static void Main(string[] args)
        {
           DateTime fecha9 = DateTime.Now;
            Console.WriteLine($"Las fechas es: {fecha9}");
            Console.ReadLine();
            var fecha = new DateTime();
            Console.WriteLine($"Las fechas es: {fecha}");
            Console.ReadLine();

            var fecha2 = new DateTime(2015,12,31);
            Console.WriteLine($"Las fechas es: {fecha2}");
            Console.ReadLine();

            var fecha3 = new DateTime(2015, 12, 31,08,12,05);
            Console.WriteLine($"Las fechas es: {fecha3}");
            Console.ReadLine();

            var fecha4 = new DateTime(2015, 12, 31, 08, 12, 05);
            Console.WriteLine($"Las fechas es: {fecha4.ToString()}");
            Console.ReadLine();

            var fecha5 = new DateTime(2015, 12, 31, 08, 12, 05);
            Console.WriteLine($"Las fechas es: {fecha5.ToString("MM/dd/yyy")}");
            Console.ReadLine();

            var fecha6 = new DateTime(2015, 12, 31, 08, 12, 05);
            Console.WriteLine($"Las fechas es: {fecha6.ToString("MM/dd/yyy hh:mm:ss")}");
            Console.ReadLine();

            var fecha7 = new DateTime(2015, 12, 31, 08, 12, 05);
            Console.WriteLine($"Las fechas es: {fecha7.AddDays(10).ToString("MM/dd/yyy")}");
            Console.ReadLine();

            var fecha8 = new DateTime(2015, 12, 31, 08, 12, 05);
            Console.WriteLine($"Las fechas es: {fecha8.DayOfWeek.ToString()}");
            Console.ReadLine();
        }
    }
}
