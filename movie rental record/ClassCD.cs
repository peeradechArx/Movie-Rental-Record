using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace movie_rental_record
{
    internal class ClassCD
    {
        private string _num;
        private string _name;
        private string _amount;
        private string _date;

        public ClassCD(string num, string name, string mounth, string date)
        {
            this._num = num;
            this._name = name;
            this._amount = mounth;
            this._date = date;
        }
        public string getNum()
        {
            return _num;
        }
        public string getName()
        {
            return _name;
        }
        public string getMounth()
        {
            return _amount;
        }
        public string getDate()
        {
            return _date;
        }
    }
}
