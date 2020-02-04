using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertTimeToMilitary
{
    class Program
    {
        static void Main(string[] args)
        {


            
                Console.WriteLine("Enter a standard (non-military) time." + Environment.NewLine);

                string userTime;
                userTime = Console.ReadLine();

                Console.WriteLine("You entered " + userTime);

                var daynight = new String(userTime.Where(Char.IsLetter).ToArray());

                userTime = userTime.Replace(daynight, "");


                string[] uTimeAry;
                uTimeAry = userTime.Split(':');


                int hour = int.Parse(uTimeAry[0].ToString());
                int min = int.Parse(uTimeAry[1].ToString());

                //If you want to convert standard time to military time, add 1200 to any time from 1:00pm to 11:00pm.
                //So if you want to say 6:30pm in military lingo, add 1200 to 6:30 to get 1830.



                int milAddValueHrs = 12;
                int milAddValueMins = 00;

                if ((daynight == "pm") && (hour >= 1 && hour <= 11))
                {
                    hour += milAddValueHrs;
                    min += milAddValueMins;
                }
                else
                {                   
                    if (hour == 12 && daynight == "am")
                    {
                        hour = 0;
                    }

                }

            if (hour.ToString().Length + min.ToString().Length < 4)
            {
                Console.WriteLine("0" + hour.ToString() + min.ToString());
            }
            else
            {
                Console.WriteLine(hour.ToString() + min.ToString());
            }
   


        }
    }
}
