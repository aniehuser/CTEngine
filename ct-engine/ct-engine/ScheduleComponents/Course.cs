using System;
using System.Collections.Generic;
namespace ct_engine.ScheduleComponents
{
	public class Course
    {
        public Component[] components { get; set; }
        public string name { get; }
        public string subject { get; }
        public string number { get; }
        public Boolean active { get; }
        public string semester { get; }
        public string grade { get; }
        public double credits { get; }
        public double qualityPoints { get; }
        public Dictionary<double, string> scale { get; }


        public Course(string[] input, bool active)
        {
            this.active = active;
            semester = input[0];
            subject = input[1];
            number = input[2];
            name = input[4];

            if(!active){
                grade = input[5];
                credits = Double.Parse(input[6]);
                qualityPoints = Double.Parse(input[7]);
            } else {
                credits = Double.Parse(input[5]);
                qualityPoints = -1;
                grade = "";
            }

            scale = null;
            components = null;
        }


        public override string ToString(){
            return String.Concat(semester, ", ", subject, number, ", ", name, ", ", grade);
        }
    }
}
