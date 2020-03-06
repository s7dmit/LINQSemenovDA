using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQObj_Task_38
{
    class Program
    {
        static void Main(string[] args)
        {/*
            Исходная последовательность содержит сведения
об автозаправочных станциях (АЗС). Каждый элемент последовательности включает следующие поля:
<Цена 1 литра (в копейках)> <Марка бензина> <Компания> <Улица>
Имеется не более 20 различных компаний и не более 30 различных улиц; названия компаний и улиц не содержат пробелов. В качестве марки бензина указываются числа 92, 95 или
98. Цена задается целым числом в диапазоне от 2000 до 3000.
Каждая компания имеет не более одной АЗС на каждой улице; цены на разных АЗС одной и той же компании могут различаться. Для каждой марки бензина, присутствующей в исходных данных, определить количество станций, предлагавших эту марку (вначале выводить количество станций, затем
номер марки). Сведения о каждой марке выводить на новой
строке и упорядочивать по возрастанию количества станций,
а для одинакового количества — по возрастанию значения
марки
            */

            Console.WriteLine("LINQObj38");
            List<Oil> oil = new List<Oil>();
            oil.Add(new Oil(2100,92,"Альянс","Гагарина"));
            oil.Add(new Oil(2150,95,"Граунд","Пушкина"));
            oil.Add(new Oil(2450,92,"Альянс","Горького"));
            oil.Add(new Oil(2300,98,"Ностра","Ленина"));
            oil.Add(new Oil(2400,95,"Ностра","Комсомола"));
            oil.Add(new Oil(2250,92,"Альянс","Гагарина"));
            oil.Add(new Oil(2200,95,"Боудика","Пушкина"));
            oil.Add(new Oil(2100,92,"Граунд","Пушкина"));
            oil.Add(new Oil(2800, 98, "Ностра", "Плеханова"));
            oil.Add(new Oil(2650, 98, "Граунд", "Революции"));


            //Удаление лишних станций
            for (int i=0;i<oil.Count();i++)
            { Oil o = oil[i];
                for (int j = 0; j < oil.Count(); j++)
                    if (i != j && o._company == oil[j]._company && o._street == oil[j]._street)
                        oil.Remove(oil[j]);
            }


            var res = oil.GroupBy(e => e._mark)
                .OrderBy(e => e.Count()).ThenBy(e => e.Key)
                .Select(e => e.Count() + " " + e.Key);

            foreach (string s in res)
                Console.WriteLine(s);


            /*Where(e => e.brand == m)
                .GroupBy(e => e.street,
                (k, ee) => new { street = k, max = ee.Max(e => e.price) })
                .OrderBy(e => e.max).ThenBy(e => e.street)
                .Select(e => e.max + " " + e.street)
                .DefaultIfEmpty("");
                */
        }
    }
}
