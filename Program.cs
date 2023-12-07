//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

Console.Write("Введите длину массива: ");
int N = Convert.ToInt32(Console.ReadLine());
string[] stringArray = new string[N];
void array(string[] stringArray)
{
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.WriteLine($"Введите {i + 1} элемент массива");
        stringArray[i] = Console.ReadLine();
  }
}
string[] symbol(string[] stringArray)
{
    int m = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
            m++;
    }
    string[] result = new string[m];
    int j = 0;
    for (int i = 0; i < stringArray.Length; i++)
    {
        if (stringArray[i].Length <= 3)
        {
            result[j] = stringArray[i];
            j++;
        }
    }
    return result;
}
void printArray(string[] stringArray)
{
    Console.Write("[");
    for (int i = 0; i < stringArray.Length; i++)
    {
        Console.Write($"‘{ stringArray[i]}’, ");
    }
    Console.Write("]");
}
array(stringArray);
printArray(symbol(stringArray));