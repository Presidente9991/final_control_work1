/* 
Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
либо задать на старте выполнения алгоритма. 
При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Примеры:
[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
[“Russia”, “Denmark”, “Kazan”] → []
*/

string[] FirstArray = new string[] { "1234", "1567", "-2", "computer science" };

PrintArray(FirstArray);
Console.Write("→ ");
PrintArray(NewArray());

string[] NewArray()
{
    int lenNewArray = 0;
    for (int i = 0; i <= FirstArray.Length - 1; i++)
    {
        if (FirstArray[i].Length <= 3) lenNewArray++;
    }

    string[] newArray = new string[lenNewArray];
    int idx = 0;

    for (int i = 0; i <= FirstArray.Length - 1; i++)
    {
        if (FirstArray[i].Length <= 3)
        {
            newArray[idx] = FirstArray[i];
            idx++;
        }
    }
    return newArray;
}

void PrintArray(string[] array)
{
    Console.Write("[ ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"“{array[i]}”, ");
    }
    Console.Write("] ");
}