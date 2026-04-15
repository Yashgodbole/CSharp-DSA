Question - Check whether Number is Palindrome or Not 


Logic- 

Store the original number (original = n).

Reverse the number by repeatedly taking the last digit (n % 10) and appending it to reverse.

Divide n by 10 each time to remove the last digit.

After the loop, compare original with reverse.

If equal → it’s a palindrome.

Otherwise → not a palindrome.



Code-

using System;

class Program
{
    static void Main()
    {
        // Check Palindrome Number
        int n = 121;
        int original = n;
        int reverse = 0;

        while (n > 0)
        {
            int digit = n % 10;              // get last digit
            reverse = reverse * 10 + digit; // build reversed number
            n = n / 10;                     // remove last digit
        }

        if (original == reverse)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not Palindrome");
    }
}


Example - 

Input: 121 → Reverse = 121 → Output: Palindrome

Input: 123 → Reverse = 321 → Output: Not Palindrome

