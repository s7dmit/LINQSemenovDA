using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQObj_Task6
{
    public class Fitnes
    {
        public int _id;       //уникальный id клиента
        public int _hours;    //продолжительность занятий в часах
        public int _year;     //год посещения фитнесс центра
        public int _month;    //номер месяца посещения фитнесс центра

        public Fitnes(int id, int hours, int year, int month)
        {
            if (id >= 10 && id <= 99) _id = id;
            if (hours >= 1 && hours <= 30) _hours = hours;
            if (year >= 2000 && year <= 2010) _year = year;
            if (month >= 1 && month <= 12) _month = month;
        }
    }
}
