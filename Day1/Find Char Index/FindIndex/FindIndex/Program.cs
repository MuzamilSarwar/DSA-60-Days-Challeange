//problem Statemnet

    //find index of any character in a string. 

    //example:

    //find index 'c' in the word "Facebook"

//Code For Main Function

Console.WriteLine("Kindly Enter String");
string str = Console.ReadLine();
Console.WriteLine("Kindly Enter the Charecter Which you want To Find");
char chr= char.Parse(Console.ReadLine());

int result = FindIndexOfChar(str, chr);
if( result>=0)
{
    Console.WriteLine($"index of c is {result}");
}
else
{
    Console.WriteLine("Given Char is not fond in String");
}

//Function for Finding Char
int FindIndexOfChar(string s, char f)
{
    for (int i = 0; i < s.Length; i++)
    {
        if (f == s[i])
        {
            return i;
        }
    }
    return -1;
}

//Function for finding char and its count

void FindIndex(string s, char f)
{
    int count = 0;
    for (int i = 0; i < s.Length; i++)
    {
        if (f == s[i])
        {
            count++;
        }

    }
}