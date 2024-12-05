namespace Assignment_5._2._4
{
    internal class Program
    {
        public static bool IsPalindrome(string s, int start, int end)
        {
            if (start >= end)
            {
                return true;
            }

            if (s[start] != s[end])
            {
                return false;
            }

            return IsPalindrome(s, start + 1, end - 1);
        }
        static void Main(string[] args)
        {
            Console.Write("Input a string: ");
            string input = Console.ReadLine();

            string formattedInput = input.ToUpper();

            bool result = IsPalindrome(formattedInput, 0, formattedInput.Length - 1);

            if (result)
            {
                Console.WriteLine("The string is Palindrome.");
            }
            else
            {
                Console.WriteLine("The string is not Palindrome.");
            }
        }
    }
}
