using System;
using System.Collections.Generic;
using System.Linq;

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
            Exercise exercise5 = new Exercise("Study If Else stataments", "JS");

            Cohort cohort1 = new Cohort("Cohort 33");
            Cohort cohort2 = new Cohort("Cohort 34");
            Cohort cohort3 = new Cohort("Cohort 35");

            Student FortunatoMugnano = new Student("Fortunato", "Mugnano", "fortunato-mugnano", cohort1);
            Student DavidCornish = new Student("David", "Cornish", "david-cornish", cohort2);
            Student HeidiSmith = new Student("Heidi", "Smith", "heidi-smith", cohort3);
            Student PhilGrass = new Student("Phil", "Grass", "phil-grass", cohort3);
            Student MarkLong = new Student("Mark", "Long", "mark-long", cohort1);
            Student NickRiviera = new Student("Nick", "Riviera", "nick-riviera", cohort2);

            Instructor AdamSheaffer = new Instructor("Adam", "Sheaffer", "adam-sheaffer", "back-end", cohort1);
            Instructor BrendaLong = new Instructor("Brenda", "Long", "brenda-long", "front-end", cohort2);
            Instructor MoSilvera = new Instructor("Mo", "Silvera", "mo-silvera", "front-end", cohort3);
            Instructor MadyPiper = new Instructor("Mady", "Piper", "madi-piper", "back-end", cohort3);

            cohort1.StudentList.Add(FortunatoMugnano);
            cohort1.StudentList.Add(MarkLong);
            cohort2.StudentList.Add(DavidCornish);
            cohort3.StudentList.Add(HeidiSmith);
            cohort3.StudentList.Add(PhilGrass);
            cohort2.StudentList.Add(NickRiviera);

            cohort1.InstructorList.Add(AdamSheaffer);
            cohort2.InstructorList.Add(BrendaLong);
            cohort3.InstructorList.Add(MoSilvera);
            cohort3.InstructorList.Add(MadyPiper);

            AdamSheaffer.AssignExercise(FortunatoMugnano, exercise1);
            BrendaLong.AssignExercise(DavidCornish, exercise2);
            MoSilvera.AssignExercise(HeidiSmith, exercise3);
            AdamSheaffer.AssignExercise(PhilGrass, exercise4);
            AdamSheaffer.AssignExercise(FortunatoMugnano, exercise5);

            List<Student> students = new List<Student>();
            students.Add(FortunatoMugnano);
            students.Add(DavidCornish);
            students.Add(HeidiSmith);
            students.Add(PhilGrass);
            students.Add(MarkLong);
            students.Add(NickRiviera);

            List<Exercise> exercises = new List<Exercise>();
            exercises.Add(exercise1);
            exercises.Add(exercise2);
            exercises.Add(exercise3);
            exercises.Add(exercise4);
            exercises.Add(exercise5);

            foreach (Student student in students)
            {
                Console.WriteLine($"Student: {student.FirstName} {student.LastName}");
                Console.WriteLine("Exercises:");
                foreach (Exercise exercise in student.Exercises)
                {
                    Console.WriteLine($"Program: {exercise.Name} Language: {exercise.Language}");
                }
            }

            List<Cohort> cohorts = new List<Cohort>()
            {
                cohort1,
                cohort2,
                cohort3,

            };

            List<Instructor> instructor = new List<Instructor>()
            {
                AdamSheaffer,
                MoSilvera,
                BrendaLong,
                MadyPiper
            };

            List<Exercise> javascriptExercise = exercises.Where(ex => ex.Language == "JS").ToList();

            foreach (var item in javascriptExercise)
            {
                Console.WriteLine(item.Name);
            }

            var listOfStudentsInCohort = cohorts.Where(cohort => cohort.Name == "Cohort 35")
                .SelectMany(c => c.StudentList).Distinct().ToList();

            foreach (var item in listOfStudentsInCohort)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName} is in Cohort 35");
            }

            var listOfInstructors = cohorts.Where(c => c.Name == "Cohort 35").SelectMany(c => c.InstructorList).Distinct().ToList();
            foreach (var item2 in listOfInstructors)
            {
                Console.WriteLine($"{item2.FirstName} {item2.LastName}: Instructors assigned for cohort-35");
            }

            var studentsByLastName = students.OrderBy(x => x.LastName).ToList();

            foreach (var item3 in studentsByLastName)
            {
                Console.WriteLine(item3.LastName);
            }

            var studentWithoutExercises = students.Where(student => student.Exercises.Count == 0).ToList();

            foreach (var item4 in studentWithoutExercises)
            {
                Console.WriteLine($"These student does't have any exercise assigned: {item4.FirstName} {item4.LastName}");
            }

            var studentWithMostExercises = students.Select(student => new
            {
                firstName = student.FirstName,
                    lastName = student.LastName,
                    numberOfExercises = student.Exercises.Count()
            }).OrderByDescending(x => x.numberOfExercises).FirstOrDefault();

            Console.WriteLine($"The student with the most exercises: {studentWithMostExercises.firstName} {studentWithMostExercises.lastName} with {studentWithMostExercises.numberOfExercises} exercises");

            var numOfStudents = cohorts.Select(x => new
            {
                name = x.Name,
                    numOfStudentsInCohort = x.StudentList.Count()
            }).ToList();

            foreach (var item5 in numOfStudents)
            {
                Console.WriteLine($"In {item5.name} there are {item5.numOfStudentsInCohort} students.");
            }

        }
    }
}