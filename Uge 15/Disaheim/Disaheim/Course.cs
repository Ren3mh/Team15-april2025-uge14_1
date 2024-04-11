using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class Course
    {
        public string Name { get; set; }
        public int DurationInMinutes { get; set; }

        public Course() : this("default", 0)
        {

        }
        
        public Course(string name)
        {
        Name = name;
        }

        public Course(string name, int durationInMinutes) 
        { 
        Name = name;
        DurationInMinutes = durationInMinutes;
        }

        public string ToString()
        {
            return "Name: " + Name + ", Duration in Minutes: " + DurationInMinutes;
        }

    }
}
