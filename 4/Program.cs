List<int> arr = new List<int>(4);
Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
arr.Add(a);
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
arr.Add(b);
Console.WriteLine("Введите третье число:");
int c = Convert.ToInt32(Console.ReadLine());
arr.Add(c);
int i = 0;
int max = 0;
while (i <= 2)
{
    if (arr[i] > max)
    {
        max = arr[i];
        i++;
    }
    else
    {
        i++;
    }
}
Console.WriteLine("Наибольшее число:" + max);