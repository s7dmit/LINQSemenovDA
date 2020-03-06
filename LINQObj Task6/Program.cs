using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQObj_Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Исходная последовательность содержит сведения о
клиентах фитнес-центра. Каждый элемент последовательности включает следующие поля:
<Код клиента> <Продолжительность занятий (в часах)>
<Год> <Номер месяца>
Все данные целочисленные. Значение года лежит в диапазоне от 2000 до 2010, код клиента — в диапазоне 10−99, продолжительность занятий — в диапазоне 1−30. Для каждого
месяца определить суммарную продолжительность занятий
всех клиентов за все годы (вначале выводить суммарную
продолжительность, затем номер месяца). 
Сведения о каждом месяце выводить на новой строке и упорядочивать по убыванию суммарной продолжительности, а
при равной продолжительности — по возрастанию номера
месяца.
             * */
            Console.WriteLine("LINQObj6");
            List<Fitnes> fitness = new List<Fitnes>();
            fitness.Add(new Fitnes(1, 10, 2000, 4));
            fitness.Add(new Fitnes(1, 10, 2000, 4));
            fitness.Add(new Fitnes(2, 15, 2001, 4));
            fitness.Add(new Fitnes(1, 10, 2000, 3));
            fitness.Add(new Fitnes(3, 5, 2002, 3));
            fitness.Add(new Fitnes(4, 20, 2004, 5));
            fitness.Add(new Fitnes(5, 4, 2005, 6));
            fitness.Add(new Fitnes(3, 8, 2003, 5));
            fitness.Add(new Fitnes(3, 4, 2003, 7));
            fitness.Add(new Fitnes(3, 4, 2003, 8));

            var r = fitness.GroupBy(e => e._month,
                (k, ee) => new { k, sum = ee.Sum(c => c._hours) })
                .OrderByDescending(e => e.sum).ThenBy(e => e.k)
                .Select(e => e.sum + " " + e.k).DefaultIfEmpty("0");

            foreach (string s in r)
                Console.WriteLine(s);
        }
    }
}
