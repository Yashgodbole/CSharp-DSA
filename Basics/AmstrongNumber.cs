
// Armstrong Number

// 153 - > 1 + 5 + 3 = 153

int num = 153;
int original = num;
int sum = 0;

while(num > 0)
{
	int digit = num %10;
	sum = sum + digit * digit * digit ; 
	num = num /10;

}

if(sum == original)
	Console.WriteLine("Amstrong");
else
        Console.WriteLine("Not Amstrong");
