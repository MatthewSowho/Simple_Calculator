using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator
{
    public class Course
    {
        public string CourseTitle { get; set; }
        public int Score { get; set; }

        public string Grade { get; set; }

        public int Units {  get; set; }

        public int GradePoints { get; set; }

        public int QualityPoints { get; set; }

        public bool isEnrolled { get; set; }

    }
}
