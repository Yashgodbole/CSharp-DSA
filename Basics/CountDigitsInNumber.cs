// Count digits in the Number

int number = 1234567;
int count = 0;

while(number >0)
{
	count++;
	number = number / 10;
}

Console.WriteLine(count);