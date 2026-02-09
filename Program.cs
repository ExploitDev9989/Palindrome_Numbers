namespace Palindrome_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //user input
            Console.WriteLine("Enter a number to see if its palindrome: ");
            int x = int.Parse(Console.ReadLine());

            
            int work = x;
            int reverse = 0;

            while (work > 0)
            {
                // reversing the number
                int a = work % 10;

                int b = (reverse * 10) + a;
                reverse = b;
                int c = work / 10;
                work = c;
            }
            //output
            if (reverse == x)
            {
                Console.WriteLine("Palindrome");
            }
            else if (x < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Negitive Detected! Unable to continue.");
                Console.ForegroundColor = ConsoleColor.White;
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
                



        }
    }
}
