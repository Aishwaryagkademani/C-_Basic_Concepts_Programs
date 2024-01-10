using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestingWithMsTesting
{
   public class MoodAnalyserMsTesting
    {
        public string SadMoodAnalyser(string msg)
        {
            string str=msg.ToLower();
            if (str.Contains("sad"));
            return "sad";
        }

        public string HappyMoodAnalyser(string msg)
        {
            string str = msg.ToLower();
            if (str.Contains("happy")) ;
            return "happy";
        }
        

    }
}
