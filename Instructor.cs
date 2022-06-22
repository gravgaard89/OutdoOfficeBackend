using System;
using System.Collections.Generic;

namespace boom
{
    public class Instructor
    {
        public int id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string skiLevel { get; set; }
        public string snowboardLevel { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public List<string> languages { get; set; }
    }
}
