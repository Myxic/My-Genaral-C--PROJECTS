using System;
namespace Num_to_Text_and_vice_versa;
class Program 
{
    static void Main(string[] args)
    {
        Console.WriteLine("Choose an Opeartion you want to perform");
        Console.WriteLine("Enter num_to_text or type 1, OR Enter text_to_num or type 2");
      
        var input = Console.ReadLine();

        if (!string.IsNullOrWhiteSpace(input)){
            if (input.ToUpper() == "NUM_TO_TEXT" || input == "1")
            {
                Console.Write("Enter the number to convert: ");
                var number = Console.ReadLine();
                int number2 = Convert.ToInt32(number);

                Console.WriteLine(num_to_text.Numtotext(number2));

            }else if(input.ToUpper() == "TEXT_TO_NUM" || input == "2")
            {
                Console.Write("Enter the Text to convert: ");
                var text = Console.ReadLine();
                

                
            }

        }
        else
        {
            Console.WriteLine("Nice Try: Enter a valid Opeartion");
        }

        ;
    }
}

