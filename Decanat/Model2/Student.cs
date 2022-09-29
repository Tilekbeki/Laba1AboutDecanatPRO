﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model2
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Speciality { get; set; }
        public string Group { get; set; }

        public Student(int id, string name, string group, string speciality)
        {
            Id = id;
            Name = name;
            Speciality = speciality;
            Group = group;
        }

    }
}
