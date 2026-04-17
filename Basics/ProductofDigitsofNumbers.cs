//Product of Digits of Numbers

int num = 12345;
int product = 1;

while(num>0)
{
	int digit = num % 10;
	product = product * digit;
	num = num / 10;
}
Console.WriteLine(product);