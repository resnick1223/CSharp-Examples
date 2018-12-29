using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLibrary
{
    public class GpaConvertor
    {
        public float Convert(int score)
        {
            if (score >= 90)
            {
                return 4.5f;
            }
            else if (score >= 85 && score < 90)
            {
                return 4.0f;
            }
            else if (score >= 80 && score < 85)
            {
                return 3.5f;
            }
            else if (score >= 75 && score < 80)
            {
                return 3.0f;
            }
            else if (score >= 70 && score < 75)
            {
                return 2.5f;
            }
            else if (score >= 60 && score < 70)
            {
                return 2.0f;
            }
            else if (score >= 50 && score < 60)
            {
                return 1.0f;
            }
            else
            {
                return 0.0f;
            }
        }
    }
}