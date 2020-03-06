using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqObj6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LinqObj7");
            List<Fitnes> fitness = new List<Fitnes>();
            fitness.Add(new Fitnes(1, 2000, 4, 10));
            fitness.Add(new Fitnes(1, 2000, 4, 10));
            fitness.Add(new Fitnes(2, 2001, 4, 15));
            fitness.Add(new Fitnes(1, 2000, 3, 10));

            /*var r=File.ReadAllLines("result", Encoding.Default)
.Select(e =>
{
    string[] s = e.Split(' ');
    return new
    {
        hours = int.Parse(s[2]),
        code = int.Parse(s[3])
    };
}).GroupBy(e => e.code,
(k, ee) => new { k, sum = ee.Sum(c => c.hours) })
.OrderByDescending(e => e.sum).ThenBy(e => e.k)
.Select(e => e.sum + " " + e.k);
            File.WriteAllLines("result", r.ToArray(), Encoding.Default);
            */
            var r =fitness.GroupBy(e => e._month,
(k, ee) => new { k, sum = ee.Sum(c => c._hours) })
.OrderByDescending(e => e.sum).ThenBy(e => e.k)
.Select(e => e.sum + " " + e.k);
        }
    }
}
