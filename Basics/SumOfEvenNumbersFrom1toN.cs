// Sum of Even Numbers from 1 to n

int n = 10;
int sum = 0;

for(int i =2; i<=n; i=i+2) // start i from 2 for even numbers
{
	sum = sum +i;
}

Console.WriteLine(sum);
