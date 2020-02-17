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


                UInt16 hour = UInt16.Parse(uTimeAry[0].ToString());
                UInt16 min = UInt16.Parse(uTimeAry[1].ToString());

            //If you want to convert standard time to military time, add 1200 to any time from 1:00pm to 11:00pm.
            //So if you want to say 6:30pm in military lingo, add 1200 to 6:30 to get 1830.

                const UInt16 milAddValueHrs = 12;
                const UInt16 milAddValueMins = 00;

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

            string hrStr = hour.ToString();
            string minStr = min.ToString();

            if (hour.ToString().Length == 1)
                hrStr = "0" + hrStr;

            if (min < 10)
                minStr = "0" + min.ToString();

            
            Console.WriteLine(hrStr + minStr);

        }


    }
}
