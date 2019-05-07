using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Staff : Person
    {
        private string school;
        private double pay;


        public string School;
        public string Pay;


        public Staff(string _name, string _address, string _school, double _pay) : base( _name, _address)
        {
            school = _school;
            pay = _pay;
        }
        public Staff()
        {

        }

        public Staff(string _name, string _address, int v) : base(_name, _address)
        {
        }

        public override string ToString()
        {
            return $"Staff {base.ToString()}, school={school},pay={pay}";
        }
    }
}
