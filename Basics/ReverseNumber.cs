using System;

class Program
{
	static void Main()
	{
		int num = 1234;
		int reverse = 0;
		int original = num;
	
		while(n > 0)
		{
			int digit = num % 10;           // take last digit 
			reverse = reverse * 10 + digit; // build reversed number
			num = num / 10;                 // remove last digit
		}
		
		Console.WriteLine("Original: "+ original);
		Console.WriteLine("Reversed: "+ reverse);
	}
}