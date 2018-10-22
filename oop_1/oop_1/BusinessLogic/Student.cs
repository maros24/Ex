using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class Student : Person, IStudy, IDrive ,ITeach
    {
        private string _StudentID;
        private bool _Army;
        private string _DriveID;
        private string _ArmyID;
        private int _course;

        public Student() {
        }

        public Student(string name, string surname, int course, string StudentId, bool Army = false,string ArmyID = null, string DriveId = null) : base(name,surname){
            this.Army = Army;
            this.DriveID = DriveId;
            Course = course;
            this.StudentID = StudentId;
            this._ArmyID = ArmyID;
        }

        public string StudentID { get => _StudentID; private set => _StudentID = value; }
        public bool Army { get => _Army; private set => _Army = value; }
        public string DriveID {
            get {
                return _DriveID;
            }
            private set {
                if(value != null)
                    _DriveID = value;
            }
        }

        public string ArmyID {
            get {
                return _ArmyID;
            }
            private set {
                if (!Army && value != null) {
                    _ArmyID = value;
                }
            }
        }

        public int Course { get => _course; private set => _course = value; }

        

        public void Study() {

        }
        public void Drive() {
        }

        public void Teach()
        {
        }
    }
}
