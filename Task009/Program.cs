﻿// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

double Qwe(string name)
{
    System.Console.WriteLine(name);
    double Ax = Convert.ToDouble(Console.ReadLine());
    return Ax;
}

double Ax = Qwe("Введите Ax");
double Ay = Qwe("Введите Ay");
double Az = Qwe("Введите Az");
double Bx = Qwe("Введите Bx");
double By = Qwe("Введите By");
double Bz = Qwe("Введите Bz");

double AB = Math.Sqrt(Math.Pow((Bx-Ax), 2) + Math.Pow((By-Ay), 2) + Math.Pow((Bz-Az), 2));
System.Console.WriteLine(Math.Round(AB, 2));