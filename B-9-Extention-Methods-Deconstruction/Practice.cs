﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base_Lesson_9.Practice
{
    public static class Practice
    {
        /// <summary>
        /// L9-P-EX-1/2
        /// Создать структуру Coordinates (трехмерных). 
        /// Добавить экземплярный метод деконструкции значений координат.
        /// Вывести на консоль длину вектора по координатам.
        /// </summary>
        public static void L9_P_EX_1_from_2()
        {
            var coordinate1 = new Coordinates {a = 1, b = 2, c = 3 };
            var (_, _, _, result) = coordinate1;
            Console.WriteLine(result);
        }

        public struct Coordinates
        {
            public int a, b, c;
            public void Deconstruct(out int a, out int b, out int c, out double vector)
            {
                a = this.a;
                b = this.b;
                c = this.c;
                vector = Math.Sqrt(a*a + b*b + c*c);
            }
        }

        /// <summary>
        /// L9-P-EX-2/2. 
        /// Создать деконструктор для обьекта DateTime 
        /// (год, месяц, день, час, минуты, секунды). 
        /// Получить и вывести на консоль текущее время.
        /// Использовать пустые параметры.
        /// </summary>
        public static void L9_P_EX_2_from_2()
        {
            DayTime now = new DayTime()
            {
                Year = DateTime.Now.Year,
                Month = DateTime.Now.Month,
                Day = DateTime.Now.Day,
                Hours = DateTime.Now.Hour,
                Minutes = DateTime.Now.Minute,
                Seconds = DateTime.Now.Second
            };

            var (_, _, _, hour, minutes, seconds) = now;
            Console.WriteLine($"{hour} {minutes} {seconds}");
        }
    }

    public class DayTime
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public int Hours { get; set; }
        public int Minutes { get; set; }
        public int Seconds { get; set; }

    }

    public static class DayTimeExtention
    {
        public static void Deconstruct(this DayTime now, out int year, out int month,
            out int day, out int hour, out int minute, out int second)
        {
            year = now.Year;
            month = now.Month;
            day = now.Day;
            hour = now.Hours;
            minute = now.Minutes;
            second = now.Seconds;

        }
    }
}
