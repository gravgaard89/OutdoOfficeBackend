using System;
using System.Collections.Generic;

namespace boom
{
    public class Lesson
    {
        public int bookingID { get; set; }
        public int instructorID { get; set; }
        public string date { get; set; }
        public int from { get; set; }
        public int to { get; set; }
        public string location { get; set; }
        public bool isSnowboard { get; set; }
        public bool isPaid { get; set; }
    }
}
