using System;
using System.Diagnostics;
using System.Threading;
using System.Xml.Linq;

namespace Pomo_App
{
	public class TimeInterval
	{
		private DateTime startTime;
		private DateTime EndTime;
		private string state;
		private TimeOnly timmer;

		public TimeInterval()
		{
			startTime = DateTime.Now;
			EndTime = DateTime.Now;
			state = "";
			


		}
		public static void CheckTime()
        {
			

		}
	}
}

