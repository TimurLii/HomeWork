// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше,
//  либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.
Console.Clear();
Console.WriteLine("Введите данные :");
string[] word = Console.ReadLine()!.Split().ToArray();
string[] new_word = new string[word.Length];
int i = 0;
while (i < word.Length)
{
    int word_Length = word[i].Length;
    if (word_Length <= 3)
    {
        new_word[i] += word[i];
        Console.Write($"{new_word[i]} ");
    }
    i++;
}


// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []
