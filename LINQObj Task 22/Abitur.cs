using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQObj_Task_22
{
    public class Abitur
    {
        public string _family;       //фамилия
        public int _school;    //номер школы
        public int _year;     //год поступленя

        public Abitur(string family, int school, int year)
        {
            _family = family;
            if (school%100>0&& school % 100<100) _school = school;
            if (year >= 1990 && year <= 2010) _year = year;
        }
    }
}
