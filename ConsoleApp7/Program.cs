using System;
    class Projet
    {
        public static void Main(string[] args)
        {
        Console.WriteLine("enter age in days : ");
        string a = Console.ReadLine();
        int x = Convert.ToInt32(a);
        age(x);
        Console.ReadKey();
        }
        private static void age (int x)
    {
        int year, month, week, day;
         year = x / 365;
        x %= 365;
         month = x / 30;
        x %= 30;
         week = x / 7;
        x %= 7;
         day = x;
        Console.WriteLine("the year of birth is : " + year);
        Console.WriteLine("the month of birth is : " + month);
        Console.WriteLine("the week of birth is : " + week);
        Console.WriteLine("the day of birth is : " + day);
    }
    }//برنامه ای بنویسید که سن فرد بر حسب روز گرفته و به سال و ماه و هفته و روز تبدیل کند

