//Problem Statement

    //Find the Given Number is Prime or Not


Console.WriteLine("kinldy enter any number");
int num = int.Parse(Console.ReadLine());

IsPrime(num);
ISprime(num);
void IsPrime(int num)
{
    int count = 0;

    for (int i = 1; i <= num; i++)
    {
        if (num % 1 == 0 && num % i == 0)
        {
            count++;
        }

    }
    if (count == 2)
    {
        Console.WriteLine("given number is prime ");
    }
    else
    {
        Console.WriteLine("Given number is not prime");
    }
}

//Second Way

void ISprime(int num)
{
    bool flag = false;

    for (int i = 2; i <= num/2; i++)
    {
        if (num % i == 0)
        {
            flag = true;
            break;
        }

    }
    if (flag)
    {
        Console.WriteLine("given number is not prime ");
    }
    else
    {
        Console.WriteLine("Given number is prime");
    }
}
