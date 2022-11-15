using System;
namespace Guessing_Game
{
	public class Guess
	{
		public List<int> tries;
		public int guess;
		public Guess()
		{
            tries = new List<int> { };
            guess = 25;
        }
		public static void guessing()
		{
            var myClass = new Guess();
            List<int> tries = myClass.tries;
            int guess = myClass.guess;
            while (true)
            {

                Console.WriteLine("Guess my number");
                int input = Convert.ToInt32(Console.ReadLine());

                // recording the number of tries
                if (tries.IndexOf(input) == -1)
                {
                    tries.Add(input);
                }

                // checking for the guesses
                if (input > guess + 10)
                {
                    Console.WriteLine("Your number is too large");
                }
                else if (input < guess - 10)
                {
                    Console.WriteLine("Your number is too small");
                }
                else if (input < guess && input > guess - 10)
                {
                    Console.WriteLine("Your number is a little small");
                }
                else if (input > guess && input < guess + 10)
                {
                    Console.WriteLine("Your number is a little big");
                }
                else if (input == guess)
                {
                    Console.WriteLine("Congrats");
                    break;
                }
                // this is doing nothing except adding space for readable output
                Console.WriteLine(" ");

            }

            Console.WriteLine($"You made {tries.Count} tries");
        }
	}
}

