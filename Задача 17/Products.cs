using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_17
{
    class Product <T>
    {
        public T Num { get; set; }
        public string Name { get; set; }
        public float Summa  { get; set; }

        //public Product(T num, string name, int summa)
        //{
        //    Num = num;
        //    Name = name;
        //    Summa = summa;
        //}

        public string GetInfo()
        {
            return $"{Num} {Name} {Summa}";
        }

        public void Input()
        {
            Console.WriteLine("Введите номер");
            Num = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            Console.WriteLine("Введите ФИО");
            Name = Console.ReadLine();
            Console.WriteLine("Введите баланс");
            Summa = Convert.ToInt32(Console.ReadLine());
        }
    }
}
