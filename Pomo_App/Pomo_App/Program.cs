using System;

namespace Pomo_App;
class Program
{
    static void Main(string[] args)
    {

        var input = Console.ReadLine();

        TimeOnly hey = TimeOnly.Parse(input);

        Console.WriteLine(hey);
        //Console.WriteLine(hey.Hour);

    }

}

