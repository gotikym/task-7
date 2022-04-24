using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Сколько у вас золота, путник?");
        int gold = Convert.ToInt32(Console.ReadLine());
        byte crystalCost = 150;
        Console.WriteLine($"Вы можете купить кристаллы в нашей лавке всего по {crystalCost} золотых, берите у нас и не проходите мимо, сколько вам нужно?");
        int crystalsCount = Convert.ToInt32(Console.ReadLine());

        if ((crystalCost * crystalsCount) > gold)
        {
            crystalsCount = gold / crystalCost;
            gold %= crystalCost;
        }

        else
        {
            gold = gold - (crystalCost * crystalsCount);
        }

        Console.WriteLine($"Золото: {gold} Кристаллы: {crystalsCount}");
    }
}
