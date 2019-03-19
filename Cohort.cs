using System;
using System.Collections.Generic;

namespace studentExercises {

    public class Cohort {
        public Cohort (string cohortname) {
            cohort = cohortname;
            studentList = new List<Student> ();
            instructorList = new List<Instructor> ();
        }
        public string cohort { get; set; }
        public List<Student> studentList { get; set; }
        public List<Instructor> instructorList { get; set; }

    }
}