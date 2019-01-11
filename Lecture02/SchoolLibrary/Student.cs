using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolLibrary
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float Height { get; set; }
        public float Weight { get; set; }

        /// <summary>
        /// 計算學生的BMI指數
        /// </summary>
        public float BMI
        {
            get
            {
                float height = this.Height / 100.0f;
                float weight = this.Weight;

                // 回傳 返回
                return weight / (height * height);
            }
        }

        public static void WriteLine(Student student)
        {
            Console.WriteLine("學生:{0}，身高{1}cm，體重{2}kg"
                                , student.Name, student.Height, student.Weight);
        }

        public static void WriteLine(Student[] students)
        {
            foreach (Student student in students)
                WriteLine(student);
        }
    }
}