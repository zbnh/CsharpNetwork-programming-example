using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class dotNetTeacher:HenuTeacher
    {
        public void teach()
        {
            Console.WriteLine("打开Visual Studio 2010");
            Console.WriteLine("事实理论授课");
        }
        public void selfintroduction()
        {
            Console.WriteLine("我是.Net{0}老师,我来自{1}", base.getname(), base.getcenter());
        }
    }
}
