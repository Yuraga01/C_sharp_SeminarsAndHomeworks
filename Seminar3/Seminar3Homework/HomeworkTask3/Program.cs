﻿//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел 
//от 1 до N.


void PrintCubTab(int N){
    if (N < 1) {
        Console.WriteLine("There are no valid numbers");
    }else{
        Console.Write($"{N} --> ");
        for (int i = 1; i <= N; i++){            
            Console.Write($"{Math.Pow(i,3)}; ");
        }
        Console.WriteLine(" ");
    }  
}

//-------------------------

Console.Write("Please n: ");
int num = int.Parse(Console.ReadLine());
PrintCubTab(num);

