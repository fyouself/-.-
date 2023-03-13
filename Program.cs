// Задача: Написать программу, которая из имеющегося массива строк формирует массив из
//  строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно
//   ввести с клавиатуры, либо задать на старте выполнения алгоритма.
//    При решении не рекомендуется пользоваться коллекциями, лучше обойтись 
//    исключительно массивами.

System.Console.Write("Введите количество cтрок в вашем массиве: ");
int n = Convert.ToInt32(Console.ReadLine());
string[] arrayWords = new string[n];
int count = 0;
for (int i = 0; i < n; i++)
{
    System.Console.Write($"Введите вашу {i + 1}ю строку: ");
    arrayWords[i] = Convert.ToString(Console.ReadLine());
    if (arrayWords[i].Length <= 3) count++;
}

string[] newArray = new string[count];
int j = 0;
for (int i = 0; i < n; i++)
{
    if (arrayWords[i].Length <= 3)
    {
        newArray[j] = arrayWords[i];
        j++;
    }
}


System.Console.WriteLine($"[{string.Join(", ", arrayWords)}]");
System.Console.WriteLine($"[{string.Join(", ", newArray)}]");