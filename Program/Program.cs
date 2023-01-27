Console.Clear();

string[] array1 = new string[10] {"23", "fg", "fj6", "34gsfd", "3f", "dfg", "3457", "dfgfsd", "dfj5", "1"};
string[] array2 = new string[array1.Length];

void SecondArrayWithIF(string[] array1, string[] array2)
{
    int verno = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[verno] = array1[i]; 
        verno++;      
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SecondArrayWithIF(array1, array2);
PrintArray(array2);
