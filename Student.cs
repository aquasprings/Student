using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentBO
{
    public class Student
    {
        int id;
        string name;
        long contact;
        string city;

       

        public Student(string name,long contact,string city)
        {
            this.name = name;
            this.contact = contact;
            this.city = city;
        }
        public Student(int id,string name, long contact, string city)
        {
            this.Id = id;
            this.name = name;
            this.contact = contact;
            this.city = city;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public long Contact
        {
            get
            {
                return contact;
            }

            set
            {
                contact = value;
            }
        }

        public string City
        {
            get
            {
                return city;
            }

            set
            {
                city = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
    }
}
