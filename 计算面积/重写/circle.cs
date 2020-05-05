using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 虚函数重写
{
    class circle:All
    {
        public float Circle(float R)
        {
            float CricleResult = (float)(Math.PI * R * R);
            return CricleResult;
        }

        public override float GD()
        {
            Console.Write("enter R:");
            float re = Circle(float.Parse(Console.ReadLine()));
            Console.WriteLine(re);
            return re;
        }
    }
}
