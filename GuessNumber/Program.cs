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

Console.Write("Введите количество посещений (из 19): ");
int attedance = int.Parse(Console.ReadLine());
Console.Write("Введите средний балл по практике: ");
double practiceGpa = double.Parse(Console.ReadLine());
bool goodAttedance = attedance >= 14;
bool goodGrades = practiceGpa >= 3.0;
if (goodAttedance && goodGrades)
{
    Console.WriteLine("+ Допуск к экзамену разрешен. ");
}
else if (!goodAttedance && goodGrades)
{
    Console.WriteLine("- Недостаточно посещений. Нужно отработать пропуски.");
}
else if (goodAttedance && !goodGrades)
{
    Console.WriteLine("- Низкий балл по практике. Нужно пересдать работы.");
}
else
{
    Console.WriteLine("- Проблемы и с посещаемостью, и с оценками. Срочно к преподавателю.");
}