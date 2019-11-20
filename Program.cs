using System;
using System.Collections.Generic;

namespace StudentExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercise exercise1 = new Exercise("Create a for each loop.", "JS");
            Exercise exercise2 = new Exercise("Stylize the index.", "CSS");
            Exercise exercise3 = new Exercise("Develop an app.", "React");
            Exercise exercise4 = new Exercise("Build a website.", "HTML");

            Cohort cohort1 = new Cohort("Cohort 33");
            Cohort cohort2 = new Cohort("Cohort 34");
            Cohort cohort3 = new Cohort("Cohort 35");

            Student FortunatoMugnano = new Student("Fortunato", "Mugnano", "fortunato-mugnano");
            Student DavidCornish = new Student("David", "Cornish", "david-cornish");
            Student HeidiSmith = new Student("Heidi", "Smith", "heidi-smith");
            Student PhilGrass = new Student("Phil", "Grass", "phil-grass");

            Instructor AdamSheaffer = new Instructor("Adam", "Sheaffer", "adam-sheaffer", "back-end");
            Instructor BrendaLong = new Instructor("Brenda", "Long", "brenda-long", "front-end");
            Instructor MoSilvera = new Instructor("Mo", "Silvera", "mo-silvera", "front-end");

            cohort1.StudentList.Add(FortunatoMugnano);
            cohort2.StudentList.Add(DavidCornish);
            cohort3.StudentList.Add(HeidiSmith);
            cohort3.StudentList.Add(PhilGrass);

            cohort1.InstructorList.Add(AdamSheaffer);
            cohort2.InstructorList.Add(BrendaLong);
            cohort3.InstructorList.Add(MoSilvera);

            AdamSheaffer.AssignExercise(FortunatoMugnano, exercise1);
            BrendaLong.AssignExercise(DavidCornish, exercise2);
            MoSilvera.AssignExercise(HeidiSmith, exercise3);
            AdamSheaffer.AssignExercise(PhilGrass, exercise4);

            List<Student> students = new List<Student>();
            students.Add(FortunatoMugnano);
            students.Add(DavidCornish);
            students.Add(HeidiSmith);
            students.Add(PhilGrass);

            List<Exercise> exercises = new List<Exercise>();
            exercises.Add(exercise1);
            exercises.Add(exercise2);
            exercises.Add(exercise3);
            exercises.Add(exercise4);

            foreach (Student student in students)
            {
                Console.WriteLine($"Student: {student.FirstName} {student.LastName}");
                Console.WriteLine("Exercises:");
                foreach (Exercise exercise in student.Exercises)
                {
                    Console.WriteLine($"Program: {exercise.Name} Language: {exercise.Language}");
                }
            }
        }
    }
}