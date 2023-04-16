using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateFunction_9_Bilet
{
    public class DateFunctions
    {
        public string RaznitsaDays(DateTime StartDate, DateTime EndDate)
        {
            var raznitsa = (EndDate- StartDate).TotalDays;
            return raznitsa.ToString();
        }
        public string VisokosnostGoda(DateTime date)
        {
            if (DateTime.IsLeapYear(date.Year))
            {
                return "Високосный";
            }
            return "Невисокосный";
        }

       public string VremyaSutok(DateTime date)
        {
            if (Convert.ToInt32(date.Hour) < 4)
                return "Ночь";

            else if (3 < Convert.ToInt32(date.Hour) && Convert.ToInt32(date.Hour) < 12)
                return "Утро";

            else if (11 < Convert.ToInt32(date.Hour) && Convert.ToInt32(date.Hour) < 17)
                return "День";
            else
                return "Вечер";
        }
        
        public string Formatirovanie(string format, DateTime date)
        {
            if(format == "Обычный")
            {
                string formdate = date.ToString("D");
                return formdate;
            }
            else if (format == "День, месяц, год (цифрами)")
            {
                string formdate = date.ToString("d");
                return formdate;
            }
            else if (format == "Дата и время")
            {
                string formdate = $"{date:f}";
                return formdate;
            }
            else if (format == "День")
            {
                string formdate = $"{date:M}";
                return formdate;
            }
            else
            {
                string formdate = $"{date:Y}";
                return formdate;
            }
        }
    }
}
