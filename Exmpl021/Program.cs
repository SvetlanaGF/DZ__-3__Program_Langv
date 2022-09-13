// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
Console.WriteLine("Задача 21: Найдем расстояние между двумя точками в 3D-пространстве.");
Console.WriteLine("Формула для расчета: корень кваратный из суммы квадратов разниц соответствующих координат.");
Console.WriteLine("Для точек A (3,6,8) и B (2,1,-7)");
double Difference;
double Squaring;
double Summ = 0;
double SquareRoot;
int[] Axyz = new int[] { 3, 6, 8};
int[] Bxyz = new int[] { 2, 1, -7};

for (int i=0;i<3;i++)
{
Difference = Bxyz[i]-Axyz[i];
//Console.WriteLine($"Bx-Ax = {Difference}");
Squaring = Math.Pow(Difference, 2);
//Console.WriteLine($"Квадрат разницы координат {i} = {Squaring}");
Summ = Summ + Squaring;
//Console.WriteLine($"Сумма квадратов разницы трех координат = {Summ}");
}
SquareRoot = Math.Round(Math.Sqrt(Summ),2);
Console.WriteLine($"расстояние в 3D пространстве составит {SquareRoot}");

Console.WriteLine();
Console.WriteLine("Для точек A (7,-5, 0) и B (1,-1,9)");
Axyz = new int[] {7,-5, 0};
Bxyz = new int[] {1,-1,9};
Summ = 0;
for (int i=0;i<3;i++)
{
Difference = Bxyz[i]-Axyz[i];
Squaring = Math.Pow(Difference, 2);
Summ = Summ + Squaring;
}
SquareRoot = Math.Round(Math.Sqrt(Summ),2);
Console.WriteLine($"расстояние в 3D пространстве составит {SquareRoot}");
