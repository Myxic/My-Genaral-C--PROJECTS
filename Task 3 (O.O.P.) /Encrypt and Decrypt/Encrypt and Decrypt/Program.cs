namespace Encrypt_and_Decrypt;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("what do you wanty to do (Encrypt and Decrypt: ");
        var input = Console.ReadLine();

        if (input?.ToUpper() == "ENCRYPT")
        {
            Console.WriteLine("what do you want to Encrypt: ");
            var inputEncrypt = Console.ReadLine();

            string output = Encode_and_decode.encrypt1(inputEncrypt);
            Console.WriteLine(output);

        }else if (input?.ToUpper() == "DECRYPT")
        {
            Console.WriteLine("what do you want to Decrypt: ");
            var inputDecrypt = Console.ReadLine();
            string output = Encode_and_decode.decrypt1(inputDecrypt);
            Console.WriteLine(output);
        }
        else
        {
            Console.WriteLine("Enter a Valid Option(Encrypt or Decrypt)");
        }
    }
}

