// See https://aka.ms/new-console-template for more information


/* Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма. */


Console.WriteLine("Введите 4 значения");
string[] arrayString = new string[4];


string[] FillArray(string[] array)
{
    
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = Console.ReadLine();
    }
    return array;
}

void PrintArray(string[] array)
 {
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
 }

 string[] SearchValues(string[] array)
 {
    string[] arrayValues = new string[array.Length];
    int count = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            arrayValues[count] = array[i];
            count++;
        }
    }
    return arrayValues;
 }

 string[] result = FillArray(arrayString);
 PrintArray(result);
 Console.WriteLine();
 Console.WriteLine("Значения, длина которых меньше или равна 3");
 string[] resultValues = SearchValues(result);
 PrintArray(resultValues);


