using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiProyecto
{
    public  class Date
    {
        private int _year;
        private int _month;
        private int _day;

        public Date(int year, int month, int day)
        {
            _year =CheckYear(year);
            _month =CheckMonth(month);
            _day = CheckDay(year,month,day);
        }

        private int CheckYear(int year)
        {
            if(year>1000) return year;
            throw new YearException($"Invalid {year} Year");
        }

        private int CheckDay(int year, int month, int day)
        {
            if(month==2&&day==29&&IsLeapYear(year)) return day;
            int[] months = { 0, 31,28,31,30,31,30,31,31,30,31,30,31 };
            if (day<=months[month]) return day;
            throw new DayException($"Invalid {day}");
        }

        private bool IsLeapYear(int year)
        {
            
            if(year%4==0 && year%100!=0 || year%400==0)
                return true;
            return false;
           
        }

        private int CheckMonth(int month)
        {
            if(month>0&&month<=12) return month;
            throw new MonthException($"Invalid {month}");
        }

        public override string ToString()
        {
            return $"{_year:00}/{_month:d2}/{_day:00}";
        }
    }
}
