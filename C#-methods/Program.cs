// Task 1: 
int n = 100;
if (n % 3 == 0 && n % 7 == 0)
{
    Console.WriteLine($"{n} is divisible by both 3 and 7.");
}
else
{
    Console.WriteLine($"{n} is not divisible by both 3 and 7.");
}

// Task 2: 
int m = 200;
if (n % 2 == 0 && m % 2 == 0)
{
    int sum = n + m;
    Console.WriteLine($"Sum of {n} and {m} is {sum} because both are even.");
}
else
{
    Console.WriteLine($"Either {n} or {m} is not even, so no sum calculated.");
}

// Task 3:
int countOddNumbers = 0;
for (int i = n; i <= m; i++)
{
    if (i % 2 != 0)
    {
        countOddNumbers++;
    }
}
Console.WriteLine($"There are {countOddNumbers} odd numbers between {n} and {m}.");

// Task 4: 
int sumOddNumbers = 0;
for (int i = n; i <= m; i++)
{
    if (i % 2 != 0)
    {
        sumOddNumbers += i;
    }
}
Console.WriteLine($"The sum of odd numbers between {n} and {m} is {sumOddNumbers}.");