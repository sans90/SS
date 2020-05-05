using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 虚函数重写
{
    class Cube:All
    {
        public float cube(float X)
        {
            float cubeResult = X * X;

            return cubeResult;
        }

        public override float GD()
        {
            Console.Write("enter X:");
            float re= cube(float.Parse(Console.ReadLine()));
            Console.WriteLine(re);
            return re;
        }
    }
}
