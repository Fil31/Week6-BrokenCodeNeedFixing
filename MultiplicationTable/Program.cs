﻿using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //Задание 2
            //Таблица умножения
            //Приложение предлагает пользователю ввести целое число и выводит на экран 
            //таблицу умножения от 0 до 10 с данным числом
            //исправленный до рабочего состояния код дает до 5 пунктов 

            Console.WriteLine("Enter your number:");
            Int32.TryParse(Console.ReadLine(), out int userNumber);
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine($"{i} x {userNumber} = {i * userNumber}");  //{i * userNumber} знак * выполняет умножение одного значения на другое

            }
        }
    }
}
