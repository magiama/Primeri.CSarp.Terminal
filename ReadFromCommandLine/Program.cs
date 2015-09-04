using System;
namespace ReadFromCommandLine
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Дефиниране променливи
            int a = 5, b = 0;
            
            //Въвеждане на входни параметри
            Console.Write("Въведете стийност за а: ");
            b = Convert.ToInt32(Console.ReadLine());
            
            //Печат резултат
            Console.WriteLine("Резултатът е:" + (a + b).ToString()+"\n\n\n");
            Console.ReadKey();
        }
    }
}
