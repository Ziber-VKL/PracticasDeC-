using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UlilityLibrary
{
    public class DateUtilities
    {
        public int DaysBetween(DateTime start, DateTime end)
        {
            return Math.Abs(end.Day -start.Day);
        }

        public bool IsWeekend(DateTime date)
        {
            return date.DayOfWeek == DayOfWeek.Saturday || date.DayOfWeek == DayOfWeek.Sunday;
        }

        public int GetAge(DateTime birthday)
        {
            DateTime hoy = DateTime.Now;
            int edad = hoy.Year - birthday.Year;
            return edad;
        }

    }
}
