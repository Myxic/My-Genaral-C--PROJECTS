namespace Pig_latin;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter word or sentence");
        var words = Console.ReadLine();

        if (!string.IsNullOrEmpty(words))
        {
            //make all the letters lowercase
            words = words?.ToLower();

            pigLatin.con2latin(words);
        }
        else
        {
            Console.WriteLine("Empty: Enter a valid word");
        }

       
    }
}

