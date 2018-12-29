using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    public class Score
    {
        public int Value;
        public float GPA;
        public bool IsConvertable;
        private GpaConvertor c = new GpaConvertor();

        public float ToGPA(string score)
        {
            this.IsConvertable = int.TryParse(score, out this.Value);
            if (this.IsConvertable)
            {
                this.GPA = c.Convert(Value);
            }

            return this.GPA;
        }
    }
}