using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace onctdl
{
    class Person
    {
        private string _name;
        private DateTime _birthDay;
        private string _sex;
        private string _job;

        public string Name
        {
            get
            {
                return _name;
            }

            set
            {
                _name = value;
            }
        }

        public DateTime BirthDay
        {
            get
            {
                return _birthDay;
            }

            set
            {
                _birthDay = value;
            }
        }

        public string Sex
        {
            get
            {
                return _sex;
            }

            set
            {
                _sex = value;
            }
        }

        public string Job
        {
            get
            {
                return _job;
            }

            set
            {
                _job = value;
            }
        }
        public Person()
        {
            this._name = "";
            this._birthDay = new DateTime();
            this._sex = "";
            this._job = "";
        }
        public Person(string name, DateTime brithDay, string sex, string job)
        {
            this._name = name;
            this._birthDay = brithDay;
            this._sex = sex;
            this._job = job;
        }
        public int GetAge()
        {
            int age = DateTime.Now.Year - this.BirthDay.Year;
            return age;
        }
        public string toString()
        {
            return $"PerSon\n\tName:{this._name}\n\tBirhtDay:{this._birthDay}\n\tSex:{this._sex}\n\tJob:{this._job}\n\tAge:{this.GetAge()}";
        }
    }
}
