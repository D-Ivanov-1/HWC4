
//Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
///* 452 -> 11
///* 82 -> 10
///* 9012 -> 12


//1. Считать от пользователя N
int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

//2. Подсчет цифр в числе
int NumberLen(int a)
{
    int index = 0;
    while (a > 0)
    {
        a /= 10;
        index++;
    }
    return index;
}

//3. Вывод суммы цифр в числе
void SumNumbers(int n, int len)
{
    int sum = 0;
    for (int i = 1; i <= len; i++)
    {
        sum += n % 10;
        n /= 10;
    }
    Console.WriteLine(sum);
}

void Task()
{
int number = ReadInt("Введите число: ");
int len = NumberLen(number);
SumNumbers(number, len);
}

Task();