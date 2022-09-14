// Напишите программу, которая принимает на вход число и выдаёт
// сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int ReadNumber(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int GetSumOfDigits(int num)
{
    int resultNum = 0;
    int provisionalNum = 0;
    while(num != 0)
    {
        provisionalNum = num - num % 10;
        resultNum = resultNum + (num - provisionalNum);
        num = num / 10;
    }
    return resultNum;
}

int number = ReadNumber("Введите число:");
int count = GetSumOfDigits(number);
Console.WriteLine(count);
