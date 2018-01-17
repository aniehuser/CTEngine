using System;
using System.Collections.Generic;
using System.IO;
using ct_engine.ScheduleComponents;

namespace ct_engine.FileLoading
{
	public static class FileLoader
    {
        

        public static bool TranscriptLoad(out Dictionary<string,Course> dict)
        {
            dict = null;
            FileInfo info = new FileInfo();
            string filename = info.path + info.file + info.extension;

            if (!Directory.Exists(info.path)){
                Console.WriteLine("Path to csv does not exist");
                return false;
            }

            if(!File.Exists(filename)){
                Console.WriteLine("csv file does not exist");
                return false;
            }






            return true;
        }

    }



}

