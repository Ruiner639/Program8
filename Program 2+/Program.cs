using System;

namespace Program_2_
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var hour = DateTime.Now.Hour;
            string hour_string = "eror";
            var day = DateTime.Now;
            var monday = "07.12.2020";
            var day_m = DateTime.Parse(monday);
            var today = 10;
            int i = 1;
            while (today != i)
            {
              if (day.DayOfWeek == day_m.DayOfWeek)
                {
                    today = i;
                }
                else
                {
                    day_m = day_m.AddDays(1);
                    i++;
                }
            } if((hour >= 4) && (hour <= 11))
            {
                hour_string = "Good morning, ";
            }
            else if ((hour >= 12) && (hour <= 17))
            {
                hour_string = "Good afternoon";
            }
            else if ((hour >= 18) && (hour <= 23))
            {
                hour_string = "Good evening, ";
            }
            if ((today - 5) <= 0)
            {
                Console.WriteLine(hour_string + "it is a lovely " + day.DayOfWeek + " today. Weekends is coming in " + (6 - today) + " days");
            }
            }
        }
    }

