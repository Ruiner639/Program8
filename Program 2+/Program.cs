using System;

namespace Program_2_
{
    class Program
    {
        static void Main(string[] args)
        {
           
            var hour = DateTime.Now.Hour;//I entered hours to determine the time of day
            string hour_string = "eror";//To display one of the lines
            var day = DateTime.Now;//date at the moment
            var monday = "07.12.2020";//day from which the week is counted by day
            var day_m = DateTime.Parse(monday);//convert string to date value
            int today;//entered a value to which the number of the day of the week will be assigned
            int i = 1;//the days of the week started from one
            while (today != i)//cycle defining the number of the day of the week
            {
              if (day.DayOfWeek == day_m.DayOfWeek)//I don’t know how to bring the time into a string, so I decided to go from the opposite and use the selection method to calculate the day
                {
                    today = i;
                }
                else
                {
                    day_m = day_m.AddDays(1);//I am adding 1 day so that the loop finds the correct today's date number
                    i++;
                }
            } if((hour >= 4) && (hour <= 11))//simple condition for finding the time of day
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
            if ((today - 5) <= 0)//determining whether the day is a work day or a day off
            {
                Console.WriteLine(hour_string + "it is a lovely " + day.DayOfWeek + " today. Weekends is coming in " + (6 - today) + " days");
            }
            else
            {
                Console.WriteLine(hour_string + "it is a lovely " + day.DayOfWeek + " today. Weekends is here!");
            }
            }
        }
    }

