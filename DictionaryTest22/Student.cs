using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DictionaryTest22
{
    public class Student
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private static int _count = 0;

        private int _id;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

       
        public bool Attendance { get; set; }

        public Student(string name, bool attendance)
        {
            _name = name;
            Attendance = attendance;
            _count++;
            _id = _count;
        }


        public override string ToString()
        {
            return $"ID {_id} Navn {_name}  attendance {Attendance}";
        }

    }
}
