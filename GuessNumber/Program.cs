// Console.Write("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// if (number > 0)
// {
//     Console.WriteLine("Число положительное.");
// }
// else if (number < 0)
// {
//     Console.WriteLine("Число отрицательное.");
// }
// else
// {
//     Console.WriteLine("Число равно нулю.");
// }

///////////////////////////////////

// Console.Write("Введите балл (0-100): ");
// int score = int.Parse(Console.ReadLine());
// if (score >= 91)
// {
//     Console.WriteLine("Оценка: отлично (5)");
// } 
// else if (score >= 71)
// {
//     Console.WriteLine("Оценка: хорошо (4)");
// }
// else if (score >= 51)
// {
//     Console.WriteLine("Оценка: удовлетворительно (3)");
// }
// else
// {
//     Console.WriteLine("Оценка: неудовлетворительно (2)");
// }

///////////////////////////////////

// Console.Write("Введите количество посещений (из 19): ");
// int attedance = int.Parse(Console.ReadLine());
// Console.Write("Введите средний балл по практике: ");
// double practiceGpa = double.Parse(Console.ReadLine());
// bool goodAttedance = attedance >= 14;
// bool goodGrades = practiceGpa >= 3.0;
// if (goodAttedance && goodGrades)
// {
//     Console.WriteLine("+ Допуск к экзамену разрешен. ");
// }
// else if (!goodAttedance && goodGrades)
// {
//     Console.WriteLine("- Недостаточно посещений. Нужно отработать пропуски.");
// }
// else if (goodAttedance && !goodGrades)
// {
//     Console.WriteLine("- Низкий балл по практике. Нужно пересдать работы.");
// }
// else
// {
//     Console.WriteLine("- Проблемы и с посещаемостью, и с оценками. Срочно к преподавателю.");
// }

///////////////////////////////////

// string result1;
// if (score >= 60)
// {
//     result1 = "Зачет";
// }
// else
// {
//     result1 = "Незачет";
// }
// string result = StringComparer >= 60 ? "Зачет" : "Незачет";

///////////////////////////////////

// Console.Write("Введите ваш возраст: ");
// int age = int.Parse(Console.ReadLine());
// string ageGroup = age >= 18 ? "Совершеннолетний" : "Несовершеннолетний";
// Console.WriteLine($"Вы {ageGroup}.");
// Console.WriteLine("\nВведите температуру за окном (°C)");
// double temp = double.Parse(Console.ReadLine());
// string weather = temp >= 20 ? "Тепло" : (temp >= 0 ? "Прохладно" : "Мороз");
// Console.WriteLine($"За окном {weather}.");
// Console.Write("\nВведите число: ");
// int n = int.Parse(Console.ReadLine());
// string parity = n % 2 == 0 ? "Четное" : "Нечетное";
// Console.WriteLine($"Число {n} - {parity}");

///////////////////////////////////

// Console.Write("Введите число: ");
// int day = int.Parse(Console.ReadLine());
// switch (day)
// {
//     case 1: Console.WriteLine("Понедельник"); break;
//     case 2: Console.WriteLine("Вторник"); break;
//     case 3: Console.WriteLine("Среда"); break;
//     case 4: Console.WriteLine("Неизвестный день"); break;
// }

///////////////////////////////////

// Console.WriteLine("Меню");
// Console.WriteLine("1. Посмотреть расписание");
// Console.WriteLine("2. Посмотреть оценки");
// Console.WriteLine("3. Связаться с преподавателем");
// Console.WriteLine("4. Выйти");
// Console.Write("Выберите пункт (1-4): ");
// string choice = Console.ReadLine();
// switch (choice)
// {
//     case "1":
//         Console.WriteLine("Расписание: ИСП-241, каб: 1.02, 08:30");
//         break;
//     case "2":
//         Console.WriteLine("Ваши оценки: ИСРПО - 100, РМП - 100");
//         break;
//     case "3":
//         Console.WriteLine("Email: denis.leontev92@yandex.ru");
//         break;
//     case "4":
//         Console.WriteLine("До свидания!");
//         break;
//     default:
//         Console.WriteLine($"Ошибка: пункт «{choice}» не существует. Введите число от 1 до 4.");
//         break;    
// }

///////////////////////////////////

// Console.Write("\nВведите номер дня недели: ");
// int dayNumber = int.Parse(Console.ReadLine());
// switch (dayNumber)
// {
//     case 1:
//     case 2:
//     case 3:
//     case 4:
//     case 5:
//         Console.WriteLine("Рабочий день - пора учиться!");
//         break;
//     case 6:
//     case 7:
//         Console.WriteLine("Выходной - заслуженный отдых.");
//         break;
//     default:
//         Console.WriteLine("Такого дня не существует.");
//         break;
// }
Console.WriteLine("Название сезона");
Console.Write("Введите число месяца: ");
int num = int.Parse(Console.ReadLine());
switch (num)
{
    case 12:
    case 1:
    case 2:
        Console.WriteLine("Название сезона - зима.");
        break;
    case 3:
    case 4:
    case 5:
        Console.WriteLine("Название сезона - весна.");
        break;
    case 6:
    case 7:
    case 8:
        Console.WriteLine("Название сезона - лето.");
        break;
    case 9:
    case 10:
    case 11:
        Console.WriteLine("Название сезона - осень.");
        break;
    default:
        Console.WriteLine("ОШИБКА: несуществующий месяц.");
        break;
}