using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class TaxiDriver : Person, IStudy, ITeach, IDrive
    {

        private string _DriverID;
        private int _Experience;

        public TaxiDriver() {
        }

        public TaxiDriver(string name, string surname, string DriverID, int Exp):base(name, surname) {
            this.DriverID = DriverID;
            Experience = Exp;
        }

        public string DriverID { get => _DriverID; set => _DriverID = value; }
        public int Experience { get => _Experience; set => _Experience = value; }

        public void Study()
        {
            
        }

        public void Drive()
        {

        }

        public void Teach()
        {

        }
    }
}
