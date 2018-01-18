using System;
using System.Collections.Generic;
using System.IO;

using ct_engine.ScheduleComponents;
using ct_engine.FileLoading;

namespace ct_engine_test
{
	public class Test
    {
        public static void Main(string[] args)
        {
            Dictionary<string, Course> dict;
            if(!FileLoader.TranscriptLoad(out dict)){
                throw new Exception();
            }

            foreach (var key in dict.Keys)
            {
                Course value;
                dict.TryGetValue(key, out value);
                Console.WriteLine(value.ToString());
            }

        }
    }
}
