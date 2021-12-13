using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ModelsTeskApp.Models
{
    public class Teacher
    {
        public Teacher(string name , string lastName, int yearOfBirth, int pay)
        {
            this.Name = name;
            this.LastName = lastName;
            this.YearOfBirth = yearOfBirth;
            this.Pay = pay;
        }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int YearOfBirth { get; set; }
        public int Pay { get; set; }

    }
}