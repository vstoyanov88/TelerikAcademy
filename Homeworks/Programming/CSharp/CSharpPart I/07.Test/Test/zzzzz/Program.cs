using System;
using System.Text;

class NewYearLucks
{
    static void Main()
    {
        Random randomGenerator = new Random();
        int luck = randomGenerator.Next(1, 15);

        Console.ForegroundColor = ConsoleColor.Red;
        Console.OutputEncoding = Encoding.Unicode;
        Console.WriteLine("Честита Новата 2013-та година!!!\n");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("С пожелания за много здраве, щастие, любов, \nкъсмет, сбъднати мечти и постигнати цели!\n");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Твоя новогодишен късмет е:\n");

        Console.ForegroundColor = ConsoleColor.Yellow;
        switch (luck)
        {
            case 1:
                Console.WriteLine("Здравето на теб се падна,\nбодър, весел – до амина...");
                break;
            case 2:
                Console.WriteLine("През новата година всичко ще върви по ноти,\nв джоба ти ще има все едри банкноти!");
                break;
            case 3:
                Console.WriteLine("Навред ще си добре приет, \nзащото паднал ти се е големият късмет!");
                break;
            case 4:
                Console.WriteLine("Таз година работата ти се пада.\nАла и печалба – за награда!");
                break;
            case 5:
                Console.WriteLine("Куфарите си стегни, \nще пътуваш ти до тайнствени страни!");
                break;
            case 6:
                Console.WriteLine("Женитба днес късметът ти вещае,\nпрез новата година любов ще те омае!");
                break;
            case 7:
                Console.WriteLine("Година те чака красива, съдбовна,\nще бъдеш в плен на магия любовна!");
                break;
            case 8:
                Console.WriteLine("Имаш нужда от заслон,\nще получиш собствен дом.");
                break;
            case 9:
                Console.WriteLine("Не измисляй как да кръшкаш,\nимаш още изпити да тръшкаш!");
                break;
            case 10:
                Console.WriteLine("През огън и вода, \nще стигнеш до целта!");
                break;
            case 11:
                Console.WriteLine("Голяма компания и купони до зори -\nтова е късметът ти за идните 365 дни!");
                break;
            case 12:
                Console.WriteLine("Заслужи го, няма съмнение, \nще получиш скоро повишение.");
                break;
            case 13:
                Console.WriteLine("На тебе мързелът се пада - \nда мързелуваш ти приляга.");
                break;
            case 14:
                Console.WriteLine("Ще имаш приятели нови,\nза тебе на всичко готови!");
                break;
        }
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.WriteLine();
    }
}