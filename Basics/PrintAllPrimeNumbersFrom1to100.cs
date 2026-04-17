// Print all Prime Numbers from 1 to 100

for(int i = 2; i<= 100; i++) // Outer loop → checks numbers from 2 to 100
{
	bool isPrime = true;

	for(int j = 2 ; j<=i/2; j++) // Inner loop → checks if i is divisible by any number
	{
		if(i % j == 0) // If divisible → not prime
		{
			isPrime = false;
			break;
		}
	}

	if(isPrime) // If not → print it
	Console.WriteLin(i + " ");
}