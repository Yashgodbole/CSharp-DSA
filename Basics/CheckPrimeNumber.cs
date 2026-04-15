// Check Prime Number 
// A prime number is a natural number greater than 1 that has exactly two divisors: 1 and itself.


using System;
class Program
{
	static void Main()
	{
		int num = 13;
		bool isPrime = true;
		
		if(num<= 1)
			isPrime = false;
		else
		{
			for(int i =2; i<= num/2; i++) // for(int i = 2; i<= Math.Sqrt(num); i++)  this is more optimized way 
			{
				if(num % i == 0)
				{
					isPrime = false;
					break; // only break when divisor is found
				}
			}
		}
		if(isPrime)
			Console.WriteLine("It's a Prime Number");
		else
			Console.WriteLine("Not a prime Number");
	}
}

// Explanation

// Check small cases first: Numbers ≤ 1 are not prime.
//Loop from 2 to num/2: If any divisor divides evenly, mark isPrime = false and break.
//After loop: If no divisor was found, isPrime stays true.
//Output: Print the correct message.