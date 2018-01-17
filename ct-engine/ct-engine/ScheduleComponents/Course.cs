using System;
using System.Collections.Generic;
namespace ct_engine.ScheduleComponents
{
	public class Course
    {
        public Component[] components { get; set; }
        public string name { get; }
        public string courseNumber { get; }
        public Boolean active { get; }
        public string semester { get; }
        public string professor { get; }
        public double grade { get; }
        public Dictionary<string, double> scale { get; }


        public Course()
        {
            
        }
    }
}
