using System;
using System.Collections.Generic;

namespace StudentExercise
{

    public class Instructor
    {
        public Instructor(string first, string last, string slack, string specialty)
        {
            FirstName = first;
            LastName = last;
            Slack = slack;
            Speciality = specialty;
        }

        string FirstName { get; }
        public Cohort CurrentCohort { get; set; }
        public void AssignExercise(Student student, Exercise exercise)
        {
            student.Exercises.Add(exercise);
        }
        private string LastName { get; }
        private string Slack { get; }
        private string Speciality { get; }
    }
}