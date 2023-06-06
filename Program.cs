Console.Write("Введите количество элементов массива: ");
int m = Convert.ToInt32(Console.ReadLine());

string[] stringArray1 = new string[m];
string[] stringArray2 = new string[stringArray1.Length];

void FillArray(string [] stringArray)
{
    for (int i = 0;i<stringArray.Length;i++)
    {
        Console.Write($"Введите {i+1} элемент массива: ");
        stringArray[i] = Console.ReadLine();
    }
}