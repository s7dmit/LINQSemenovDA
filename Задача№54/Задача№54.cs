﻿using System;
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
            /*Даны строковые последовательности A и B; все
строки в каждой последовательности различны, имеют ненулевую
длину и содержат только цифры и заглавные буквы латинского алфавита. 
Найти последовательность всех пар строк, удовлетворяющих следующим условиям: 
первый элемент пары принадлежит последовательности A, а второй либо является 
одним из элементов последовательности B, начинающихся с того же символа, что и первый
элемент пары, либо является пустой строкой (если B не содержит
ни одной подходящей строки). Результирующая последовательность
называется левым внешним объединением последовательностей A и
B по ключу, определяемому первыми символами исходных строк.
Представить найденное объединение в виде последовательности
строк вида «EA.EB», где EA – элемент из A, а EB – либо один из соответствующих ему элементов из B, либо пустая строка. Расположить
элементы полученной строковой последовательности в лексикографическом порядке по возрастанию.
Указание. Использовать методы GroupJoin, DefaultIfEmpty, Select и SelectMany.
             * */
            //IEnumerable<string> a = new[] { "A", "4", "F","B2","4CS","7H7","8I" };
            //IEnumerable<string> b = new[] { "A7", "AJ", "4Q","4V","F5","5F","8JH","8H7" };

            string[] a= new[] { "A", "4", "F", "B2", "4CS", "7H7", "8I" };
            string [] b= new[] { "A7", "AJ", "4Q", "4V", "F5", "5F", "8JH", "8H7" };
            var subset=a.GroupJoin(b, e => e[0], e => e[0],(e1, ee2) => ee2.DefaultIfEmpty("")
            .Select(e => e1 + "." + e)).SelectMany(e => e).OrderBy(e => e);

            foreach (string s in subset)
                Console.WriteLine(s);
        }
    }
}
