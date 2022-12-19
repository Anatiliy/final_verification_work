//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

//Примеры:
//[“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
//[“1234”, “1567”, “-2”, “computer science”] → [“-2”]
//[“Russia”, “Denmark”, “Kazan”] → []


void FilterArray(string[] array1, int index = 0)
{
    if (index < array1.Length)
    {
        Console.WriteLine(array1[index]);
        FilterArray(array1, index + 1);
    }
    else
    {
        Console.WriteLine();
    }

}


string[] array1 = new string[4] {"Hello", "2", "world", ":-)"};
string[] array2 = new string[4] {"1234", "1567", "-2", "computer science"};
string[] array3 = new string[3] {"Russia", "Denmark", "Kazan"};


FilterArray(array1);
FilterArray(array2);
FilterArray(array3);
//Console.WriteLine(FilterArray(array3));