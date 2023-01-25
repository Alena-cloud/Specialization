// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна трем символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не  рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
// Примеры: ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
//          ["1234", "1567", "-2", "computer science"] -> ["-2"]
//          ["Russia", "Denmark", "Kazan"] -> []

string[] array1 = { "hello", "2", "world", ":-)" };
string[] array2 = { "1234", "1567", "-2", "computer science" };
string[] array3 = { "Russia", "Denmark", "Kazan" };

int MaxCharacterLength = 3;
string[] GetShortCharacterArray(string[] array)
{
    int length = array.Length;
    string[] result = new string[length];
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (array[i].Length <= MaxCharacterLength)
        {
            result[count] = array[i];
            count++;
        }
    }
    Array.Resize(ref result, count);
    return result;
}
void PrintArray(string[] array)
{
    if (array.Length == 0)
    {
        Console.WriteLine("Array is empty!");
    }
    else
    {
        Array.ForEach(array, (str) => Console.WriteLine($"{str} "));
        Console.WriteLine();
    }
}
void PrintTask(string[] array)
{
    Console.WriteLine("Source array: ");
    PrintArray(array);
    string[] shortArray = GetShortCharacterArray(array);
    Console.WriteLine("Result array: ");
    PrintArray(shortArray);
    Console.WriteLine();
}
PrintTask(array1);
PrintTask(array2);
PrintTask(array3);
