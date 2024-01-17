using System.Globalization;
using System.Threading.Channels;

namespace _04.ReverseString
{
    internal class Program
    {
        static void Main()
        {
            string originalString = Console.ReadLine();

            char[] charArray = originalString.ToCharArray();
            Array.Reverse(charArray);
            string reversedString = new string(charArray);

            Console.WriteLine(reversedString);
        }
    }
}
