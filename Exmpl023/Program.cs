
// Задача 23
// Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
Console.WriteLine("Задача 23: Создадим таблицу кубов чисел от 1 до N.");
int N;
double Cubes;
Console.Write("Введите значение N: ");
N = Convert.ToInt32(Console.ReadLine());

for (int i=1;i<N+1;i++)
{
Cubes = Math.Pow(i, 3);
Console.WriteLine($"{i} ^ 3 = {Cubes}");
//Console.WriteLine();
}
