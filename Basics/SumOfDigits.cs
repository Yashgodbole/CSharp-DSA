// Sum of Digits

int num = 1234;
int sum =0;

while(num>0)
{
	sum = sum + (num % 10);
	num = num /10;
}
