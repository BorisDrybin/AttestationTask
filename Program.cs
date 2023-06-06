Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());

string[] stringArray1 = new string[m];
string[] stringArray2 = new string[stringArray1.Length];

void FillArray(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        stringArray[i] = Console.ReadLine();
    }
}

void OverwriteArray(string[] stringArray1, string[] stringArray2)
{
    int count = 0;
    for (int i = 0; i < stringArray1.Length; i++)
    {
        if (stringArray1[i].Length <= 3)
        {
            stringArray2[count] = stringArray1[i];
            count++;
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

FillArray(stringArray1);
PrintArray(stringArray1);
OverwriteArray(stringArray1, stringArray2);
PrintArray(stringArray2);