using System;
using System.Collections.Generic;

namespace StudentExercise
{
    public class Student
    {
        public Student(string first, string last, string slack)
        {
            FirstName = first;
            LastName = last;
            Slack = slack;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public string Slack { get; }
        public Cohort CurrentCohort { get; set; }
        public List<Exercise> Exercises = new List<Exercise>();
    }
}