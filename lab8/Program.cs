Console.WriteLine("Введите x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y");
int y = Convert.ToInt32(Console.ReadLine());
try
{
    int z = x / y;
    if (x == 0)
    {
        throw new Exception("Ошибка");
    }
    else
    {
        Console.WriteLine($"Ответ {z}");
    }
}
catch (Exception j) when (x == 0)
{
Console.WriteLine($"Исключение {j.Message}");
}
catch (Exception r)
{
    Console.WriteLine(r.Message);
}
