using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo11
{
    public class TrabalhandoComDatas
    {

        public void AulaDateTime()
        {
            var date1 = new DateTime(2012, 12, 02, 19,22,23);
            var date2 = DateTime.Parse("2024/12/22 19:25:23");
            var date3 = DateTime.Now;
            var date4 = DateTime.Today;
           
            Console.WriteLine(date1);
            Console.WriteLine(date2);
            Console.WriteLine(date3);
            Console.WriteLine(date4);

            Console.WriteLine(date1.ToString("dd-MM-yyyy HH:mm:ss"));
            Console.WriteLine("");

            var dateOFFset = new DateTimeOffset(DateTime.Now, new TimeSpan(-3, 0, 0));
            Console.WriteLine(dateOFFset);
            Console.WriteLine(dateOFFset.LocalDateTime);
            Console.WriteLine(dateOFFset.UtcDateTime);
        }

        public void AulaSubtraindoDatas()
        {
            var data1 = DateTime.Now;
            var data2 = DateTime.Parse("2001-09-25");

            var diff = data1 - data2;
            //var diff = data1.Substract(data2);  //segunda forma de fazer a subtração

            Console.WriteLine((int)diff.TotalDays);
            Console.WriteLine((int)diff.TotalHours);
        }
        public void AulaAdicionadoDiasMesesAnos()
        {
            var data1 = DateTime.Now;
            Console.WriteLine(data1.AddDays(3).ToString("dd-MM-yyyy HH:mm:ss")); //adicionando dias a data atual
            Console.WriteLine(data1.AddMonths(3).ToString("dd-MM-yyyy HH:mm:ss")); //adicionando meses a data atual
            Console.WriteLine(data1.AddYears(3).ToString("dd-MM-yyyy HH:mm:ss")); //adicionando anos a data atual
        }
        public void AulaAdicionadoHorasMinutosSegundos()
        {
            var data1 = DateTime.Now;
            Console.WriteLine(data1.AddHours(3).ToString("HH:mm:ss")); //adicionando dias a data atual
            Console.WriteLine(data1.AddMinutes(3).ToString("HH:mm:ss")); //adicionando meses a data atual
            Console.WriteLine(data1.AddSeconds(3).ToString("HH:mm:ss")); //adicionando anos a data atual
        }

        public void AulaDiaDaSemana()
        {
            var data1 = DateTime.Now;
            Console.WriteLine(data1.DayOfWeek);
        }
        public void AulaDateOnly()
        {
            //var somenteData = new DateOnly(2021, 12, 25);
            var somenteData = DateOnly.Parse("2021-12-25");

            Console.WriteLine(somenteData);
        }
        public void AulaTimeOnly()
        {
            //var OutraVariavel = new TimeOnly(23, 01, 23);
            var somenteHora = TimeOnly.Parse("23:01:23");
            Console.WriteLine(somenteHora.ToString("HH:mm:ss"));
        }
    }
}
