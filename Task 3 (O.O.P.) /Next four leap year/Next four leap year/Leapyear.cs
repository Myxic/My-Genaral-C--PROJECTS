using System;
namespace Next_four_leap_year
{
	public class Leapyear
	{
        public int count;
        public int leap_year;
        public int totalyears;
        public Leapyear()
		{
            count = 4;
            leap_year = 2020;
            totalyears = 20;
        }
        public static void NextLeapYears()
        {
            var Leapyear = new Leapyear();
            int count = Leapyear.count;
            int totalyears = Leapyear.totalyears;
            int leapYear = Leapyear.leap_year;
            while (count < totalyears)
            {
                //since leap years are always after 4yrs or can be divided by 4
                leapYear = leapYear + 4;

                Console.WriteLine(leapYear);
                count += 4;
            }
        }
	}
}

