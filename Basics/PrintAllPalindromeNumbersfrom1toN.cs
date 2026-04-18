// Print All Palindrome Numbers from 1 to 1000

if(int num =0; num<=1000; num++)
{
	int original = num;
	int reverse = 0;

	while(num>0)
	{
	int digit = num%10;
	reverse = reverse*10 +digit;
	num = num/10;
	}

if(original == reverse)
Console.WriteLine(original + " ");

n=original;

}
