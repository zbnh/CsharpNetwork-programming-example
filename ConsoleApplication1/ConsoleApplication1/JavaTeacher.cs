﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class JavaTeacher:HenuTeacher
    {
        public override void teach()
        {
            Console.WriteLine("打开Eclipse");
            Console.WriteLine("事实理论授课");
        }
        public override void selfintroduction()
        {
            Console.WriteLine("我是Java{0}老师,我来自{1}",base.getname(),base.getcenter());
        }
    }
}