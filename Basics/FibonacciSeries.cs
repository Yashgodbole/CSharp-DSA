// Fibonacci Series - series of numbers where each number is the sum of the two preceding ones

// (0,1,1,2,3,5,8,13,21,34...)

int num =10;
int a =0, b=1;

for(int i = 1; i<=num; i++)
{
	Console.WriteLine(a + " ");
	int temp = a+b;
	a=b;
	b=temp;
}

