using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class HenuTeacher
    {
        string name;
        string center;
        public void setname(string name)
        {
            this.name = name;
        }
        public void setcenter(string center)
        {
            this.center = center;
        }
        public string getname()
        {
            return name;
        }
        public string getcenter()
        {
            return center;
        }
        public virtual void teach()
        {

        }
        public virtual void selfintroduction()
        {
            Console.WriteLine("我是{0}老师,我来自{1}", name, center);
        }
    }
}
