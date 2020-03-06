using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQObj_Task_38
{
    public class Oil
    {
        public int _price;     //цена литра бензина
        public int _mark;    //марка бензина
        public string _company;    //компания
        public string _street;       //улица
        
        public Oil(int price,int mark,string company,string street)
        {
            if (price >= 2000 && price <= 3000) _price = price;
            if (mark ==92||mark==95||mark==98) _mark = mark;
            if (company.Contains(" ") == false) _company = company;
            if (street.Contains(" ")==false) _street = street;
        }
    }
}
