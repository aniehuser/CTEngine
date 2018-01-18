using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

using ct_engine.ScheduleComponents;

namespace ct_engine.FileLoading
{
    public static class FileLoader
    {


        public static bool TranscriptLoad(out Dictionary<string, Course> dict)
        {
            dict = null;
            FileInfo info = new FileInfo();
            string path = info.path + info.file + info.extension;

            //establish path and file are correct
            if (!Directory.Exists(info.path))
            {
                Console.WriteLine("Path to csv does not exist");
                return false;
            }

            if (!File.Exists(path))
            {
                Console.WriteLine("csv file does not exist");
                return false;
            }

            //read csv and load dictionary
            dict = new Dictionary<string, Course>();
            using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open)))
            {
                string line = reader.ReadLine();
                while (line != null)
                {
                    Course course;
                    string[] data = line.Split(',');
                    Console.WriteLine(line);

                    if(!validCourse(out course, data)){
                        Console.WriteLine("Line not a valid course: ");
                        line = reader.ReadLine();
                        continue;
                    }

                    dict.Add(course.subject+course.number, course);


                    line = reader.ReadLine();
                }
            }




            return true;
        }

        private static bool validCourse(out Course course, string[] input)
        {
            course = null;
            if(input.Length!=6 && input.Length!=8){
                Console.WriteLine("incorrect input formatting");
                return false;
            }

            int index = 0;
            if(!Regex.Match(input[index++], @"(Spring|Fall) [12][0-9]{3}").Success){
                Console.WriteLine("Not a semester: " + input[index-1]);
                return false;
            }
            if (!Regex.Match(input[index++], "[A-Z]{4}").Success){
                Console.WriteLine("Not a subject: " + input[index - 1]);
                return false;
            }
            if (!Regex.Match(input[index++], "[1-4][0-9]{2}[A-Z]?").Success){
                Console.WriteLine("Not a course number: " + input[index - 1]);
                return false;
            }
            //TODO:: remove "UG" when scraping html
            index++; //skip "UG" part

            index++; //skip course title

            if (Regex.Match(input[index], "[A-Z][+-]?").Success)
            {
                Console.WriteLine("Inactive Course");
                course = new Course(input, false);
            } else if(Regex.Match(input[index], @"[0-4]\.000").Success){
                Console.WriteLine("Active Course");
                course = new Course(input, true);
            } else {
                Console.WriteLine("Improper Formatting");
                return false;
            }

            return true;
        }
    }
}

