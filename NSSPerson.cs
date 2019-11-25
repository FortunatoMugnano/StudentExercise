using System;
using System.Collections.Generic;

namespace StudentExercise
{

    public class NSSPerson
    {
        public string _firstName { get; set; }
        public string _lastName { get; set; }
        public string _slackHandle { get; set; }
        public Cohort CurrentCohort { get; set; }
    }
}