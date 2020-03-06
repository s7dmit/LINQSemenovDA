using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQObj_Task_22
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Исходная последовательность содержит сведения
об абитуриентах. Каждый элемент последовательности
включает следующие поля:
<Фамилия> <Номер школы> <Год поступления>
Номер школы содержит не более двух цифр, годы лежат в
диапазоне от 1990 до 2010. Для каждого номера школы, присутствующего в исходных данных, вывести общее число
абитуриентов за все годы (вначале указывать число абитуриентов, затем номер школы). 
Сведения о каждой школе выводить на новой строке и упорядочивать по возрастанию числа
абитуриентов, а для одинаковых чисел — по возрастанию
номеров школ.
             * */
            Console.WriteLine("LINQObj22");
            List<Abitur> people = new List<Abitur>();
            people.Add(new Abitur("Иванов",1,2000));
            people.Add(new Abitur("Петров",31,2001));
            people.Add(new Abitur("Сидоров",19,1998));
            people.Add(new Abitur("Будько",1,1996));
            people.Add(new Abitur("Буханкина",31,2002));
            people.Add(new Abitur("Иванова",19,2003));
            people.Add(new Abitur("Иванов",1,2006));
            people.Add(new Abitur("Иванов",31,2010));
            people.Add(new Abitur("Опенкина",19,1991));
            people.Add(new Abitur("Динабург",1,1999));

            var y = people.GroupBy(e => e._school).OrderBy(e=>e.Count()).ThenBy(e => e.Key)
                .Select(e => e.Count() + " " + e.Key);

            foreach (string s in y)
                Console.WriteLine(s);

        }
    }
}
