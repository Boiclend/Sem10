// Известны год и номер месяца рождения человека, а также год и номер месяца сегодняшнего дня. Определить возраст человека (число полных лет и число полных месяцев). При определении числа полных месяцев дни месяца не учитывать, а использовать разность между номерами месяцев. Например, если месяц рождения — февраль, а текущий (сегодняшний) месяц — май,
// то число полных месяцев равно трем независимо от дня рождения и сегодняшнего дня.


using System;
namespace example
{
    class example_1
    {
        public int year, month, day;
        public void info()
        {
            Console.Write("Year = ");
            year = int.Parse(Console.ReadLine());
            Console.Write("Month = ");
            month = int.Parse(Console.ReadLine());
            Console.Write("Day = ");
            day = int.Parse(Console.ReadLine());
        }
        public int year_2, month_2, day_2;
        public void info_t()
        {
            Console.Write("Today's year = ");
            year_2 = int.Parse(Console.ReadLine());
            Console.Write("Today's month = ");
            month_2 = int.Parse(Console.ReadLine());
            Console.Write("Today's day = ");
            day_2 = int.Parse(Console.ReadLine());
        }
      public int result_year,result_month;
        public void Result()
        {
            if ((month_2 -month) > 0)
            {
                result_month = month_2 - month;
                result_year = year_2 - year;
                Console.WriteLine("Получается {0} лет и {1} месяцов ", result_year, result_month);
            }
            else {
                result_month = month_2 + 12 - month;
                result_year = year_2 - 1 - year;
                Console.WriteLine("Получается {0} лет и {1} месяцов ", result_year, result_month);
            }
        }
        static void Main()
        {
            example_1 vadym = new example_1();
            Console.WriteLine("Настоящая дата рождения : ");
            vadym.info();
            Console.WriteLine("\nHа сегодняшний день : ");
            vadym.info_t();
           
            vadym.Result();
            Console.ReadLine();   
            
        }
    }
}
