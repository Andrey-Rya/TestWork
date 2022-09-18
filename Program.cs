// Напишите программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых
// меньше или равна трём символам. Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно
// массивами.

Console.Clear();
int n = 0;
Examination(n); // проверка на правильность ввода количества строк
string[] strs = new string[n];
string[] strs2 = new string[strs.Length];
InputArray(strs); // ввод строк с клавиатуры

PrintInputArray(strs); // печать начального массива

NewArray(strs, strs2); //вычисляем и печатаем новый массив не более 3-х символов

void Examination(int num)
{
    Console.Write("Введите количество строк одномерного массива, которое хотите ввести:  ");
    while (!int.TryParse(Console.ReadLine(), out n)) Console.Write("Неверный ввод! Вводите только цифры! ");
    Console.WriteLine();
}

void InputArray(string[] strs)
{
    for (int i = 0; i < n; i++)
    {
    Console.Write("Введите строку №{0}:    ", i+1);
    strs[i] = Console.ReadLine();
    }
}    

void PrintInputArray(string[] strs)
{
    Console.Write("\nВы ввели этот массив: [");
    for (int i = 0; i < strs.Length; i++)
    {
        Console.Write(' ' + string.Join(",", strs[i]) + ',');
    }
    Console.Write(" ]");
}

void NewArray(string[] strs, string[] strs2)
{
    int count = 0;
    for (int i = 0; i < strs.Length; i++)
    {
        if (strs[i].Length <= 3)
        {
            strs2[count] = strs[i];
            count++;
        }
    }
    Console.Write("\n\nИтоговый массив из строк не более 3-х символов: [");
    for (int i = 0; i < count; i++)
    {
        Console.Write(' ' + string.Join(",", strs2[i]) + ',');
    }
    Console.Write(" ]");
}
