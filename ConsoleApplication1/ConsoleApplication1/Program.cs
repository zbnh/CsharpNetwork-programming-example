using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("第一题输入1，第二题输入2");
            int input;
            input = Convert.ToInt32(Console.ReadLine());
            switch (input)
            {
                case 1:
                    exercise1();
                    break;
                case 2:
                    exercise2();
                    break;
                default:
                    Console.WriteLine("我不认识你输入的是什么^^");
                    break;
            }
        }
        public static void exercise1()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 7 == 0)
                    Console.Write("{0}\n", i);
            }
            Console.ReadLine();
        }
        public static void exercise2()
        {
            JavaTeacher javateacher = new JavaTeacher();
            javateacher.setname("李老师");
            javateacher.setcenter("rjxy");
            javateacher.teach();
            javateacher.selfintroduction();
            dotNetTeacher dotnetteacher = new dotNetTeacher();
            dotnetteacher.setname("刘老师");
            dotnetteacher.setcenter("rjxy");
            dotnetteacher.teach();
            dotnetteacher.selfintroduction();
            Console.ReadLine();
        }
    }
}
