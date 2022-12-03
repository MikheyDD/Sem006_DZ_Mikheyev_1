// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа через запятую или через пробел");
var stringNums = Console.ReadLine();

string[] numsArray = stringNums.Split(' ', ',');
int[] numsArrayConvert = ConvertNums(numsArray);
Print(numsArrayConvert);
Console.WriteLine();
Console.WriteLine(GetCount(numsArrayConvert));

int GetCount(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count++;
        }
    }
    return count;
}

int[] ConvertNums(string[] arr)
{
   int[] arrayConvert = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        arrayConvert[i] = Convert.ToInt32(arr[i]);
    }
    return arrayConvert;
}

void Print(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item}, ");
    }
}