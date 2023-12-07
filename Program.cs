//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
//длина которых меньше, либо равна 3 символам. 
//Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. 
//При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

int Getnum(string message)
{
     Console.WriteLine(message);
    int num = int.Parse(Console.Readline()!); 
    return num;
 }
string[] symbol(int[] arr)
{
    int n = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)
            n++;
    }
    string[] result = new string[n];
    int j = 0;
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i].Length <= 3)
        {
            result[j] = stringArray[i];
            j++;
        }
    }
    return result;
}
void PrintArray(int[] arr)
{
    for (int i = 0; i < Array.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}
array(stringArray);
PrintArray(symbol(stringArray));
