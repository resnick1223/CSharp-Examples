using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolLibrary;

namespace MyToolbox
{
    public class Faker
    {
        #region 建立姓名列表

        private static string[] firstNames = new string[]
        {
                "莊", "林", "孫", "劉", "謝", "張", "江","丁",
                "陳", "廖", "邱", "薛", "吳", "李", "顏", "曾",
                "高"
        };

        private static string[] lastNames = new string[]
        {
                "婉瑜", "永健", "顯宗", "鈺如", "宗冀", "士豪",
                "敦華", "鴻偉", "富恩", "清山", "建霆", "志偉",
                "仲堯", "偉志", "金慶", "俊雄", "珮婷", "盈憲",
                "雅玲", "帛儒"
        };

        #endregion 建立姓名列表

        // 建立一個亂數產生器 random 物件
        private static Random random = new Random();

        public static string FindName()
        {
            // 透過 random 物件 產生亂數
            int firstNameIndex = random.Next(firstNames.Length);
            int lastNameIndex = random.Next(lastNames.Length);

            string firstName = firstNames[firstNameIndex];
            string lastName = lastNames[lastNameIndex];

            return firstName + lastName;
        }

        public static double FindHeight(double min, double max)
        {
            return min + (max - min) * random.NextDouble();
        }

        public static double FindWeight(double min, double max)
        {
            return min + (max - min) * random.NextDouble();
        }

        public static Student FindStudent()
        {
            return new Student()
            {
                Name = Faker.FindName(),
                Height = (float)Faker.FindHeight(150, 220),
                Weight = (float)Faker.FindWeight(30, 100)
            };
        }

        public static Student[] FindStudents(int length)
        {
            Student[] students = new Student[length];
            for (int index = 0; index < students.Length; index++)
            {
                students[index] = Faker.FindStudent();
            }

            return students;
        }
    }
}