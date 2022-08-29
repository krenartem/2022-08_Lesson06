// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// ввод чисел
int[] InputNumbers(int x)
{
    int[] arrayNumbers = new int[x];
    for (int i = 0; i < x; i++)
    {
        Console.Write($"Введите число {i+1}: ");
        arrayNumbers[i] = int.Parse(Console.ReadLine());
    }
    return arrayNumbers;
}

// счетчик положительных значений
void PositiveNumbersCounter(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            counter++;
        }
    }
    Console.WriteLine($"Вы ввели {counter} положительных чисел");
}


Console.Clear();
Console.WriteLine("Какое количество чисел вы хотите ввести?");
int number = Convert.ToInt32(Console.ReadLine());
int[] userArray = InputNumbers(number);
PositiveNumbersCounter(userArray);