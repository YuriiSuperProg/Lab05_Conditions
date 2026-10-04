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

// Console.WriteLine("Название сезона");
// Console.Write("Введите число месяца: ");
// int num = int.Parse(Console.ReadLine());
// switch (num)
// {
//     case 12:
//     case 1:
//     case 2:
//         Console.WriteLine("Название сезона - зима.");
//         break;
//     case 3:
//     case 4:
//     case 5:
//         Console.WriteLine("Название сезона - весна.");
//         break;
//     case 6:
//     case 7:
//     case 8:
//         Console.WriteLine("Название сезона - лето.");
//         break;
//     case 9:
//     case 10:
//     case 11:
//         Console.WriteLine("Название сезона - осень.");
//         break;
//     default:
//         Console.WriteLine("ОШИБКА: несуществующий месяц.");
//         break;
// }

///////////////////////////////////

// Random random = new Random();
// int secret = random.Next(1, 101);
// int attempts = 0;
// bool guessed = false;
// Console.WriteLine("Угадай число (1-100)");
// Console.WriteLine("Я загадал число. Попробуй угадать!");
// while (!guessed)
// {
//     Console.WriteLine($"Попытка {attempts + 1}. Твой вариант: ");
//     string input = Console.ReadLine();
//     if (!int.TryParse(input, out int guess))
//     {
//         Console.WriteLine("!!! Введи целое число, а не текст");
//         continue;
//     }
//     if (guess < 1 || guess > 100)
//     {
//         Console.WriteLine("!!! Число должно быть от 1 до 100");
//         continue;
//     }
//     attempts++;
//     if (guess < secret)
//     {
//         int diff = secret - guess;
//         string hint = GetHint(diff);
//         Console.WriteLine($"⬆️ Больше! {hint}\n");
//     }
//     else if (guess > secret)
//     {
//         int diff = secret - guess;
//         string hint = GetHint(diff);
//         Console.WriteLine($"⬇️ Меньше! {hint}\n");
//     }
//     else
//     {
//         guessed = true;
//     }
// }
// string result = attempts <= 7 ? $"Отличный результат! Всего {attempts} попыток." : $"Число найдено за {attempts} попыток. Можно лучше!";
// Console.WriteLine($"🎉 Правильно! Загаданное число: {secret}");
// Console.WriteLine($"{result}");
// string GetHint(int difference)
// {
//     switch (difference)
//     {
//         case <= 3:
//             return "🔥 Горячо!";
//         case <= 10:
//             return "🌡️ Тепло.";
//         case <= 25:
//             return "⛄️ Прохладно.";
//         default:
//             return "❄️ Холодно!";
//     }
// }

//////////////////// Самостоятельные задания \\\\\\\\\\\\\\\\\\\\

/// Задание 1 \\\

// Console.Write("Введите пароль: ");
// string parol = Console.ReadLine();
// Console.Write("Введите подтверждение: ");
// string addParol = Console.ReadLine();
// Console.WriteLine(parol == addParol ? "Пароль принят" : "Пароль не принят");

/// Задание 2 \\\

// Console.Write("Введите свой возраст: ");
// int age = int.Parse(Console.ReadLine());
// Console.WriteLine(age >= 18 ? "Доступ разрешен" : "Доступ запрещен! Вам нет 18 лет.");

/// Задание 3 \\\

// Console.WriteLine("🖥️ Калькулятор");
// Console.Write("Введите число 1: ");
// double num1 = double.Parse(Console.ReadLine());
// Console.Write("Введите число 2: ");
// double num2 = double.Parse(Console.ReadLine());
// Console.Write("Введите операцию (+, -, *, /): ");
// string operation = Console.ReadLine();
// switch (operation)
// {
//     case "+":
//         Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
//         break;
//     case "-":
//         Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
//         break;
//     case "*":
//         Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
//         break;
//     case "/":
//         Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
//         break;
//     default:
//         Console.WriteLine("Такой операции нет. Выберите из (+, -, *, /). ");
//         break;
// }

/// Задание 4 \\\

// Console.WriteLine("Сумма положительных");
// Console.Write("Введите число 1: ");
// double num1 = double.Parse(Console.ReadLine());
// Console.Write("Введите число 2: ");
// double num2 = double.Parse(Console.ReadLine());
// Console.Write("Введите число 3: ");
// double num3 = double.Parse(Console.ReadLine());

// if (num1 >= 0 && num1 >= 0 && num3 >= 0)
// {
//     Console.WriteLine(num1 + num2 + num3);
// }
// else if (num1 >= 0 && num2 >= 0 && num3 <= 0)
// {
//     Console.WriteLine(num1 + num2);
// }
// else if (num1 >= 0 && num2 <= 0 && num3 >= 0)
// {
//     Console.WriteLine(num1 + num3);
// }
// else if (num1 <= 0 && num2 >= 0 && num3 >=0)
// {
//     Console.WriteLine(num2 + num3);
// }
// else if (num1 >= 0 && num2 <= 0 && num3 <= 0)
// {
//     Console.WriteLine(num1);
// }
// else if (num1 <= 0 && num2 >= 0 && num3 <= 0)
// {
//     Console.WriteLine(num2);
// }
// else if (num1 <= 0 && num2 <= 0 && num3 >= 0)
// {
//     Console.WriteLine(num3);
// }
// else
// {
//     Console.WriteLine("Все числа отрицательные");
// }

/// Задание 5 \\\

// Console.WriteLine("Темный лабиринт");
// Console.WriteLine("Вы стоите перед первой дверью. Перед вами два пути - Путь A и Путь B");
// Console.Write("Выберить путь (A или B): ");
// string choice = Console.ReadLine().ToUpper();
// if (choice == "A")
// {
//     Console.WriteLine($"Вы вошли в комнату с огромным драконом.");
//     Console.WriteLine("Вам нужно будет ответить на загадку дракона: ");
//     Console.WriteLine("Дракон говорит: «Кто не дышит, но живёт; хоть не нужно — много пьёт; и в жизни, и в смерти тело как лёд.»");
//     Console.Write("Ваш ответ: ");
//     string otv1 = Console.ReadLine().ToLower();
//     if (otv1 == "рыба")
//     {
//         Console.WriteLine("Правильно! Дракон открывает дверь в следующую комнату."); 
//     }
//     else
//     {
//         Console.WriteLine("Неправильно! Дракон съедает вас.");
//     }
// }
// else if (choice == "B")
// {
//     Console.WriteLine("\nВы вошли в тёмную комнату с двумя дверями.");
//     Console.WriteLine("Дверь 1: За ней скрыты сокровища Dungeon Master'а.");
//     Console.WriteLine("Дверь 2: За ней — ловушка с ядовитыми шипами.");
//     Console.Write("Какую дверь вы выберете? (1 или 2): ");
//     string choice2 = Console.ReadLine();
//     if (choice2 == "1")
//     {
//         Console.WriteLine("Вы выбрали правильную дверь и получили сокровища!");
//     }
//     else if (choice2 == "2")
//     {
//         Console.WriteLine("Вы попали в ловушку с ядовитыми шипами!");
//     }
//     else
//     {
//         Console.WriteLine("Неверный ввод. Вы стоите в нерешительности, и время уходит.");
//     }
// }
// else
// {
//     Console.WriteLine("Неверный выбор. Вы не решились сделать шаг.");
// }
    


