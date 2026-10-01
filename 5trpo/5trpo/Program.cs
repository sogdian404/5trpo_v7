Console.WriteLine("Введите число n:");
int n = int.Parse(Console.ReadLine());
Console.WriteLine($"Введено {n}");

int max = 0;
int maxSumm = 0;
int curr = 1;
int temp = 0;
while (curr <= n)
{
    
    if (n % curr == 0)
    {
        temp = curr;
        int summCurr = 0;
        while (temp != 0)
        {
            summCurr += temp % 10;
            temp /= 10;
        }
        if (summCurr >= maxSumm)
        {
            maxSumm = summCurr;
            max = curr;
        }
    }
    curr++;
}
Console.WriteLine($"делитель с макс суммой цифр = {max}, сумма цифр = {maxSumm}");
