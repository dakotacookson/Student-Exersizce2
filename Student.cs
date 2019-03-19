using System;
using System.Collections.Generic;
namespace studentExercises {
    public class Student {

        public Student (string firstname, string lastname, string slackHandle, Cohort cohortObject) {
            firstName = firstname;
            lastName = lastname;
            slack = slackHandle;
            cohort = cohortObject;
            exerciseList = new List<Exercise> ();
        }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string slack { get; set; }
        public Cohort cohort { get; set; }

        public List<Exercise> exerciseList { get; set; }

    }
}