using System;
using System.Collections.Generic;

namespace StudentExercise
{
    public class Student : NSSPerson
    {
        public Student(string first, string last, string slack, Cohort cohort)
        {
            _firstName = first;
            _lastName = last;
            _slackHandle = slack;
            CurrentCohort = cohort;
        }

        public List<Exercise> Exercises = new List<Exercise>();
    }
}