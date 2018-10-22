using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Teacher : Person, IStudy, ITeach, IDrive
    {
        private string _DriveID;
        private int _Experience;

        public Teacher() {
        }

        public Teacher(string name, string surname, int Experience, string DriveID = null) : base(name,surname) {
            this.DriveID = DriveID;
            this.Experience = Experience;
        }

        public string DriveID
        {
            get
            {
                return _DriveID;
            }
            private set
            {
                if (value != null)
                    _DriveID = value;
            }
        }

        public int Experience { get => _Experience; set => _Experience = value; }

        public void Study()
        {
            
        }

        public void Teach()
        {

        }

        public void Drive()
        {

        }
    }
}
