using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_17
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Введите номер счёта");
            //int numInt = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Введите ФИО");
            //string name = Console.ReadLine();
            //Console.WriteLine("Введите баланс");
            //int summa = Convert.ToInt32(Console.ReadLine());

            //Product<int> product1 = new Product<int>(numInt, name, summa);
            //Console.WriteLine(product1.GetInfo());

            //Console.WriteLine("Введите строковый номер счёта");
            //string numString = Console.ReadLine();
            //Console.WriteLine("Введите ФИО");
            //name = Console.ReadLine();
            //Console.WriteLine("Введите баланс");
            //summa = Convert.ToInt32(Console.ReadLine());
            //Product<string> product2 = new Product<string>(numString, name, summa);

            //Console.WriteLine(product1.GetInfo());

            Product<int> product1 = new Product<int>();
            product1.Input();
            Console.WriteLine(product1.GetInfo());
            
            Product<string> product2 = new Product<string>();
            product2.Input();
            Console.WriteLine(product2.GetInfo());

            Console.ReadKey();
        }
    }
}
