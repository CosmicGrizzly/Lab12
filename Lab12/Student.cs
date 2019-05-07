using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Student : Person
    {
        private string program;
        private int year;
        private double fee;


        public string Program;
        public int Year;
        public double Fee;
        public Student(string _name, string _address, string _program, int _year, double _fee) : base(_name, _address)
        {
            program = _program;
            year = _year;
            fee = _fee;
        }
        public Student()
        {

        }
        public override string ToString()
        {
            return $"Student[{base.ToString()}, program={program},year={year},fee={fee}"; 
        }
    }
}
