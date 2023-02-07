// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int InputNumber(string str) 
{     
System.Console.Write(str);     
return Convert.ToInt32(Console.ReadLine());
}  
int x1 = InputNumber("Введите координату x первой точки: ");
int y1 = InputNumber("Введите координату y первой точки: "); 
int z1 = InputNumber("Введите координату z первой точки: "); 
int y2 = InputNumber("Введите координату y второй точки: ");  
int x2 = InputNumber("Введите координату x второй точки: "); 
int z2 = InputNumber("Введите координату z второй точки: ");  

int a = x2 - x1;
int b = y2 - y1;
int c = z1 - z2;

double length = Math.Sqrt(a * a + b * b + c * c);
Console.WriteLine($"Длинна отрезка {length}");