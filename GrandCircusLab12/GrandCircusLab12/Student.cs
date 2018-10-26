using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab12
{
    class Student : Person
    {
 
        public Student(string Name, string Address, string Program, int Year, double Tuition) : base(Name, Address)
        {
            this.Program = Program;
            this.Year = Year;
            this.Tuition = Tuition;
        }

        public string Program { get; private set; }
        public int Year { get; private set; }
        public double Tuition { get; private set; }

        public override string ToString()
        {
            return string.Format("{0,-10}", "Name: ") + Name + "\n" + string.Format("{0,-10}", "Address: ") + Address + "\n" +
                string.Format("{0,-10}", "Program: ") + Program + "\n" + string.Format("{0,-10}", "Year: ") + Year + "\n" +
                string.Format("{0,-10}", "Tuition: ") + Tuition;
        }

        public void EditProgram(string program)    { Program = program; }

        public void EditYear(int year)     { Year = year; }

        public void EditTuition(double tuition)    { Tuition = tuition; }

    }
}
