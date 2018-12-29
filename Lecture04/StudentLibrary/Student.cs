using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    public class Student
    {
        public string Name;
        public string Email;
        public string Phone;
        public Location CurrentLocation;

        public void MoveForward(double distance)
        {
            CurrentLocation.X += distance;
        }
    }
}