using System;

namespace Master_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = 232; i <=num; i++)
            {
                bool isPalindrome = CheckIfPalindrome(i);
                bool isDevisibleBySeven = CheckIfIsDivisibleBySeven(i);
                bool ContainsAnEvenDigit = ContainsEvenDigit(i);
                if (isPalindrome && isDevisibleBySeven && ContainsAnEvenDigit) Console.WriteLine(i);
            }
        }
        static bool CheckIfPalindrome(int num)
        {
           
            double result = 0;
            int number =num;
            while (num > 0)
            {
                int dig = num % 10;
                result = result * 10 + dig;
                num = num / 10;
            }
            if (number == result) return true;
            return false;
        }
        static bool CheckIfIsDivisibleBySeven(int num)
        {
          
            int sum = 0;
            while (num != 0)
            {
                sum += num % 10;
                num /= 10;
            }
            if (sum % 7 == 0) return true;
            return false;
        }
        static bool ContainsEvenDigit(int num)
        {
            
            while (num>0)
            {
                int digit = num % 10;
                if (digit%2==0)
                {
                    return true;
                }
                num /= 10;
            }
            return false;
        }
    }
}
