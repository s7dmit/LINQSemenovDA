using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_54
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<string> a = new[] { "A", "4", "F","B2","4CS","7H7","8I" };
            IEnumerable<string> b = new[] { "A7", "AJ", "4Q","4V","F5","5F","8JH","8H7" };

            var subset=a.GroupJoin(b, e => e[0], e => e[0],(e1, ee2) => ee2.DefaultIfEmpty("")
            .Select(e => e1 + "." + e)).SelectMany(e => e).OrderBy(e => e);

            foreach (string s in subset)
                Console.WriteLine(s);
        }
    }
}
