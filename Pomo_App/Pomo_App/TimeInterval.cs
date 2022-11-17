using System;
using System.Diagnostics;
using System.Threading;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace Pomo_App
{
	public class TimeInterval
	{
		private DateTime startTime;
		private DateTime EndTime;
		private string state;
		private TimeOnly timmer;
        public int hour;
        public int min;
        public int sec;

        public TimeInterval()
		{
			startTime = DateTime.Now;
			EndTime = DateTime.Now;
			state = "";



		}
		public static DateTime AddTimeSec(int sec)
		{
			return DateTime.Now.AddSeconds(sec);
		}

		public static void CheckTime(string Time)
		{
			var MyClass = new TimeInterval();
			int hour = MyClass.hour;
            int min = MyClass.min;
            int sec = MyClass.sec;


            hour = int.Parse(Time.Split(":")[0]);
			min = int.Parse(Time.Split(":")[1]);
			sec = int.Parse(Time.Split(":")[2]);
		
			int TotalTime = (hour * 60 * 60) + (min * 60) + sec;


			Console.WriteLine(AddTimeSec(TotalTime));
			Console.WriteLine(TotalTime);
		}
		
        




    }
}

