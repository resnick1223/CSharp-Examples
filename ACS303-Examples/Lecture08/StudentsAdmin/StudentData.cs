using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAdmin
{
    public class StudentData : EventArgs
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public string[] ToStringArray()
        {
            return new string[] { Id, Name, Phone };
        }
    }
}