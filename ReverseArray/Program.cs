using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] result = ReverseString("lamp");
            string reversed = new string(result);
            Console.WriteLine(reversed);

        }

        public static char[] ReverseString (string input)
        {
            char[] userString = input.ToCharArray();
            int length = userString.Length;
            char holder;
            for (int i = 0, j = length -1; i < length / 2; i++, j--)
            {
                holder = userString[i];
                userString[i] = userString[j];
                userString[j] = holder;

            }

            return userString;
        }



    }
}
