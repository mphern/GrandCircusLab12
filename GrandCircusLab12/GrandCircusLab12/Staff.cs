using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrandCircusLab12
{
    class Staff : Person
    {


        public Staff(string Name, string Address, string School, double Salery) : base(Name, Address)
        {
            this.School = School;
            this.Salery = Salery;
        }

        public string School { get; private set; }
        public double Salery { get; private set; }

        public override string ToString()
        {
            return string.Format("{0,-10}", "Name: ") + Name + "\n" + string.Format("{0,-10}", "Address: ") + Address + "\n" +
                string.Format("{0,-10}", "School: ") + School + "\n" + string.Format("{0,-10}", "Salery: ") + Salery;
        }

        public void EditSchool(string school)   {School = school;}

        public void EditSalery(double salery)   {Salery = salery;}


    }
}
