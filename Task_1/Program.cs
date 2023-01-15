Console.Clear();
//1. Считать от пользователя N
int GetNumberByUser(string text)
{
    Console.Write(text + " ");
    return Convert.ToInt32(Console.ReadLine());
}
//2. Создание массива
int[] CreateArray(int size)
{
    return new int[size];
}
//3. Заполнение 0 и 1
void Filling(int[] Array)
{
    int count = Array.Length;

    for (int i = 0; i < count; i++)
    {
        Array[0] = 1;
        Array[i] = Random.Shared.Next(2);
    }
    
}
//4. Печать массива

string Print(int[] numbers)
{
string output = String.Empty;
int size = numbers.Length;

for (int i = 0; i < size; i++)
{
output = output + $" {numbers[i]},";
}
   return output;
}
//5. Конвертация из двоичного в десятиричное число
int BinToDec(int[] BinArray)
{
int count =BinArray.Length;
int Dec = 0;
int exponenta = BinArray.Length - 1;
for (int i = 0; i < BinArray.Length; i++)
{
    if (BinArray[i] == 1)
    {
        Dec += Convert.ToInt32(Math.Pow(2, exponenta));
    }
    exponenta--;
}
return Dec;


}

void Task()
{
int countBuUser = GetNumberByUser("Введите колличество элементов в массиве N:");
int[] list = CreateArray(countBuUser);
Filling(list);
string Result = Print(list);
int result = BinToDec(list);

System.Console.WriteLine($"\n{String.Join("", Result)} >> {result}");
}

Task();