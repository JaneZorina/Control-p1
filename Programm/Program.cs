// программа, которая из имеющегося массива строк, формирует массив из строк ,длинна которых меньше либо равна 3 символам.
string[] arrayExist = new string[4] {"hellow", "2", "world", ":-)"};
string[] arrayNew = new string[arrayExist.Length];

void ArrayForTreeDigits(string[] arrayExist, string[] arrayNew)
{
    int count = 0;
    for (int i = 0; i < arrayExist.Length; i++)
    {
    if(arrayExist[i].Length <= 3)
        {
        arrayNew[count] = arrayExist[i];
        count++;
        }
    }
}
void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
ArrayForTreeDigits(arrayExist, arrayNew);
ShowArray(arrayNew);
