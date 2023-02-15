//assignment:

//find a number between a range in an array:

//for example:

//problem: find the first index of number  4 in index range 1 and 3, if it does not exist return -1
//array = { 0,1,2,3,3,3,4}
//output should be -1


//problem: find the first index of number 4 in index range 1 and 3, if it does not exist return -1
//array = {0,1,4,3,3,3,4}
//output should be 2

//Bonus points: find all the index of the target number, (4) and return a list/array/vector

int[] arr = { 0, 1, 2, 3, 3, 3, 4 };

Console.WriteLine(FindIndex(arr, 4, 3, 6));
var list = FindindexList(arr, 3, 3, 6);
foreach (var item in list)
{
    Console.WriteLine(item);
}

int FindIndex(int[] arr , int number, int start, int end)
{
	for (int i = start; i <=end; i++) 
	{
		if (arr[i]== number)
		{
			return i;
            break;
		}
	}
	return -1;
}
List<int> FindindexList(int[] arr, int number, int start, int end)
{
    List<int> list = new List<int>();
    for (int i = start; i <=end; i++)
    {
        if (arr[i] == number)
        {
            list.Add(i);
        }
    }
    return list;

}