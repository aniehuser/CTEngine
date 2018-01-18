using System;
using System.Collections.Generic;

namespace ct_engine.ScheduleComponents
{
	public class Transcript
    {
        public Dictionary<string, Course> courses { get; set; }

        public Transcript()
        {
            //initialize Dictionary
            //1st load from csv transcript file

            //2nd load from database (should only need to load active courses)

        }
    }
}
