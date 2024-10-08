﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _2_1Lab_Net.Framework_.Domain
{
    public class Student
    {
        public Student()
        {

        }
        public Student(string Name, string Speciality, string Group) =>
            (this.Name, this.Speciality, this.Group) = (Name, Speciality, Group);

        public string Name { get; set; }
        public string Speciality { get; set; }

        public string Group { get; set; }

        public override bool Equals(object obj)
        {
            if (obj is Student student)
            {
                return Name == student.Name
                    && Speciality == student.Speciality
                    && Group == student.Group;
            }
            return false;

        }

        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 17;
                hash = hash * 23 + (Name?.GetHashCode() ?? 0);
                hash = hash * 23 + (Speciality?.GetHashCode() ?? 0);
                hash = hash * 23 + (Group?.GetHashCode() ?? 0);
                return hash;
            }
        }
    }
}

