#pragma warning disable CS8600 // Преобразование литерала, допускающего значение NULL или возможного значения NULL в тип, не допускающий значение NULL.

string str, again = "y";
int n, rnd, m, i;

while (again == "y")
{
    i = 0;
    Console.Clear();
    Console.WriteLine("Введите последнее число списка");
    n = Convert.ToInt32(Console.ReadLine());
    Random random = new Random();
    rnd = random.Next(1, n);

    Console.WriteLine("Угадай загаданное число\n");
    
    while (true)
    {
        m = Convert.ToInt32(Console.ReadLine());
        if (m == rnd)
        {
            Console.WriteLine($"Победа!!! \n {i+1} шагов");
            break;
        }
        str = m < rnd ? "Больше\n" : "Меньше\n";
        Console.WriteLine(str);
       i++;
    };

    Console.WriteLine("Продолжить игру? (y-да / n-нет)");
    again = Console.ReadLine();
};