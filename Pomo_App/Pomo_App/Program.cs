using System;


namespace Pomo_App;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your work time in this format (hh:mm:ss)");
        ////string input;
        string? txt = Console.ReadLine();
        ////int? v = int.Parse(txt) ;
        //DateTime toLongTimeString = DateTime.Parse(txt);
        ////TimeOnly here = toLongTimeString.ToLongTimeString();
        //Console.WriteLine(toLongTimeString.) ;
        //foreach (string num in txt.Split(":"))
        //{
        //    Console.WriteLine(num);
        //}

        //bool session;
        //DateTime start = DateTime.Now;
        //DateTime time = DateTime.Now.AddSeconds(25);
        //DateTime FollowTime = DateTime.Now;
        //do
        //{
        //    if (FollowTime >= time)
        //    {
        //        Console.WriteLine("here");
        //        session = false;
        //    }
        //    else
        //    {
        //        Console.Clear();
        //        FollowTime = DateTime.Now;
        //        Console.WriteLine(FollowTime.TimeOfDay);
        //        session = true;
        //    }
        //} while (FollowTime <= time);



        TimeInterval.CheckTime(txt ?? "00:00:05");
        
       

        //TimeOnly hey = TimeOnly.Parse(input);

        //Console.WriteLine(hey);
        //Console.WriteLine(hey.Hour);

    }

}

