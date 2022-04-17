using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Сколько у вас золота, путник?");
        var gold = Convert.ToInt32(Console.ReadLine());
        var crystalCost = 150;
        Console.WriteLine($"Вы можете купить кристаллы в нашей лавке всего по {crystalCost} золотых, берите у нас и не проходите мимо, сколько вам нужно?");
        var crystalCount = Convert.ToInt32(Console.ReadLine());
        if ((crystalCost * crystalCount) > gold)
        {
            crystalCount = gold / crystalCost;
            gold = gold % crystalCost;
        }
        gold = gold % (crystalCost * crystalCount);
        Console.WriteLine($"Золото: {gold} Кристаллы: {crystalCount}");
    }
}