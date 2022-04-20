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
        private string _day;
        private string _mounth;
        
        public ClassCD(string num, string name, string day, string mounth)
        {
            this._num = num;
            this._name = name;
            this._day = day;
            this._mounth = mounth;
            
        }
        public string getNum()
        {
            return _num;
        }
        public string getName()
        {
            return _name;
        }
        public string getDay()
        {
            return _day;
        }
        public string getMounth()
        {
            return _mounth;
        }
    }
}
