using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EncodingDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "23333alfjalfj";
            Encoding encodinguni = Encoding.Unicode;
            Encoding ecodingutf = Encoding.UTF8;
            byte[] unicodeBytes= encodinguni.GetBytes(str);
            byte[] utf8bytes=Encoding.Convert(Encoding.Unicode, Encoding.UTF8, unicodeBytes);
            Console.WriteLine(str+"\n"+unicodeBytes.ToString()+"\n"+utf8bytes.ToString());
            Console.Read();
        }
    }
}
