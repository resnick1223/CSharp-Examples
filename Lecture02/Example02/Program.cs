using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolLibrary;

namespace Example02
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine("建立學生資料:");
            Console.Write("請輸入學生姓名:");
            student.Name = Console.ReadLine();
            Console.Write("請輸入學生身高(cm):");
            try
            {
                student.Height = float.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("對，我就在說你，是不會好好輸入嗎");
            }

            Console.Write("請輸入學生體重(kg)");
            try
            {
                student.Weight = float.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("對，我就在說你，是不會好好輸入嗎");
            }

            Console.WriteLine("您建立的學生資料是:");
            Console.WriteLine("學生姓名:{0}", student.Name);
            Console.WriteLine("身高: {0}公分", student.Height);
            Console.WriteLine("體重: {0}公斤", student.Weight);
            Console.WriteLine("BMI: {0}", student.BMI);
        }
    }
}