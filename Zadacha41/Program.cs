void Number()
{
    Console.Clear();
    Console.WriteLine("Для остановки программы нажите 'q'.\nВведите числа больше нуля: ");
    bool GoCode = true;
    int result = 0;
    while (GoCode)
    {
        string m = Console.ReadLine();
        if (int.TryParse(m, out int n) && Convert.ToInt32(m) > 0)
        {
            result++;
        }
        else if (m == "q")
        {
            Console.Write($"Вы нажали 'q', Программа остановилась. Введено {result} значений.\n");
            GoCode = false;
        }
    }
}

Number();

