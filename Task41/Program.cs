// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.Clear();
// Считывание числа с консоли
int Prompt(string message)
{
    System.Console.WriteLine(message); // вывод сообщения
    string? value = Console.ReadLine(); // считывание строки с консоли
    int result = Convert.ToInt32(value); // преобразование строки в целое число
    return result; // возврат результата
}

// Ввод массива
int[] InputArray(int length)
{
    int [] array = new int[length];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt ($"Введите {i + 1}-й элемент");
    }
    return array;
}

void PrintArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine($"a[{i}] = {array[i]}");
    }
}

int CountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        count++;
    }
    return count;
}

int Length = Prompt("Введите количество элементов >");
int[] array;
array = InputArray(Length);
PrintArray(array);
Console.WriteLine($"Количество чисел больше 0 - {CountPositiveNumbers(array)}");