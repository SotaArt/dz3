
//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве. 
//A (3,6,8); B (2,1,-7), -> 15.84 
//A (7,-5, 0); B (1,-1,9) -> 11.53 

Console.WriteLine("Вводим координаты X точки a"); 
    double xa = Convert.ToDouble (Console.ReadLine()!); 
Console.WriteLine("Вводим координаты Y точки a"); 
    double ya = Convert.ToDouble (Console.ReadLine()!); 
Console.WriteLine("Вводим координаты Z точки a"); 
    double za = Convert.ToDouble (Console.ReadLine()!); 
Console.WriteLine("Вводим координаты X точки b"); 
    double xb = Convert.ToDouble (Console.ReadLine()!); 
Console.WriteLine("Вводим координаты Y точки b"); 
    double yb = Convert.ToDouble (Console.ReadLine()!); 
Console.WriteLine("Вводим координаты Z точки b"); 
    double zb = Convert.ToDouble (Console.ReadLine()!); 
        double d = Math.Sqrt (Math.Pow (xb-xa,2) + Math.Pow (yb-ya,2) + Math.Pow (zb-za,2)); 
Console.WriteLine($"d={d:f2}"); 
