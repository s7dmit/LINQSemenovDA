using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_22
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Даны целое число K (> 0) и строковая последовательность A. Строки последовательности содержат только цифры
и заглавные буквы латинского алфавита. Извлечь из A все строки
длины K, оканчивающиеся цифрой, отсортировав их в лексикографическом порядке по возрастанию.
             * */
            int k = 4;
            //IEnumerable<string> arr = new []{ "K34R", "AKL2", "SBR4", "G2T6", "D23S4", "AKLM", "23S5", "2DRF4","AMB3","24S6" };
            //.EndsWith?
            string [] arr = new[] { "K34R", "AKL2", "SBR4", "G2T6", "D23S4", "AKLM", "23S5", "2DRF4", "AMB3", "24S6" };
            var subset = arr.Where(s => s.Length == k&&char.IsDigit(s,s.Length-1)).OrderBy(s=>s).Select(s=>s);
            foreach (string s in subset)
                Console.WriteLine(s);
        }
    }
}
