using System;
using System.Collections.Generic;

namespace StudentExercise
{

    public class Cohort
    {
        public Cohort(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public List<Student> StudentList = new List<Student>();
        public List<Instructor> InstructorList = new List<Instructor>();
    }
}