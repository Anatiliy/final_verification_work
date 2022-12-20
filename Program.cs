//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []


string[] FilterArray(string[] array1, string[] array2, int requiredlength = 3)
{
    int index2 = 0;
    for (int index1 = 0; index1 < array1.Length; index1++)
    {
        if (array1[index1].Length <= requiredlength)
        {
            Array.Resize(ref array2, index2 + 1);
            array2[index2] = array1[index1];
            index2 = index2 + 1;
        }
          
    }
    return array2;
}


void PrintArray(string[] array1, int index = 0)
{
    if (index < array1.Length)
    {
        Console.WriteLine(array1[index]);
        PrintArray(array1, index + 1);
    }
    else
    {
        Console.WriteLine();
    }

}


string[] array1 = new string[4] {"Hello", "2", "world", ":-)"};
string[] array2 = new string[4] {"1234", "1567", "-2", "computer science"};
string[] array3 = new string[3] {"Russia", "Denmark", "Kazan"};
string[] resultarray = new string[0];


PrintArray(FilterArray(array1, resultarray));
PrintArray(FilterArray(array2, resultarray));
PrintArray(FilterArray(array3, resultarray));