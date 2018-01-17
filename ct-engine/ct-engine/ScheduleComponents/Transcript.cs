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
            //1st load from database

            //2nd load from csv transcript file

        }
    }
}
