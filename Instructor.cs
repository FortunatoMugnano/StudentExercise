using System;
using System.Collections.Generic;

namespace StudentExercise
{

    public class Instructor : NSSPerson
    {
        public Instructor(string first, string last, string slack, string specialty, Cohort cohort)
        {
            _firstName = first;
            _lastName = last;
            _slackHandle = slack;
            Speciality = specialty;
            CurrentCohort = cohort;
        }

        public void AssignExercise(Student student, Exercise exercise)
        {
            student.Exercises.Add(exercise);
        }
        private string Speciality { get; }
    }
}