using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Semenov_D.A
{
    class Program
    {
        static void Main(string[] args)
        {
            /*LINQBegin6
             * Дана строковая последовательность. Найти сумму
длин всех строк, входящих в данную последовательность.
             * */
            //IEnumerable <string> arr = new []{ "Kesha", "Artem", "Svetlana" };
            string[] arr= new[] { "Kesha", "Artem", "Svetlana" };
            int sum = arr.Aggregate<string, int>(0, (a, b) => a + b.Length);
            Console.WriteLine($"sum = {sum}");
        }
    }
}
