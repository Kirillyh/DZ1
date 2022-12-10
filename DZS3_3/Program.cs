// Задача 20: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

Console.WriteLine("Введите координаты x1:");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты y1:");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты x2:");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты y22:");
int y2 = Convert.ToInt32(Console.ReadLine());

// int x3 = x1 -x2;
// int y3 = y1 - y2;
// double respoun = Math.Pow(x3, 2);              //  Формула AB = √AC2 + BC2  
// double respoun2 = Math.Pow(y3, 2);              //  Math.Pow - возведения числа в степень
// double simpow = respoun + respoun2;
// double result = Math.Sqrt(simpow);              //  Math.Sqrt - математическая функция которая извлекает квадратный корень.
// Console.WriteLine($"Растояние между точками: {result:f2}");

  double res = Math.Sqrt(Math.Pow(x1-x2, 2)+Math.Pow(y1-y2, 2));
  Console.WriteLine($"Итог{res:f2}");