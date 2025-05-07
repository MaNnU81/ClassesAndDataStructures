using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndDataStructures
{
    internal class Student
    {
        //private string _name;
        //private string _surname;
        //private string _gender;
        //private int _yob;

        //public Student(string name, string surname, int yob)
        //{
        //    _name = name;
        //    _surname = surname;
        //    _gender = "neutral";
        //    _yob = yob;
        //}
        //public Student(string name, string surname, string gender, int yob)
        //{
        //    _name = name;
        //    _surname = surname; 
        //    _gender = gender;
        //    _yob = yob;
        //}

        public string Name { get;  }  //volendo posso togliere set e si puo solo leggere (get) e non variare(set)
        public string Surname { get; set; }
        public string Gender { get; set; }

        private string _name;
        private string _surname;
        private string _gender;
        private int _yob;
        public int Yob 
        {
            get => _yob;

            set
            {
                if (value < 1900)
                {
                    _yob = 1900;
                }
                else
                {
                    _yob = value;
                }
            }
                
         }

        public Student(string name, string surname, int yob)
        {
            _name = name;
            _surname = surname;
            _gender = "neutral";
            _yob = yob;

        }


        public Student(string name, string surname, string gender, int yob) 
        {
            Name = name;
            Surname = surname;
            Gender = gender;
            Yob = yob;
        }    

    }
}
