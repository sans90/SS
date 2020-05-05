using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 虚函数重写
{
    class delta:All
    {
        public float Delta(float Long,float Hight)
        {
            float DeltaResult = Long * Hight / 2;

            return DeltaResult;
        }

        public override float GD()
        {
            Console.Write("enter L,H:");

            float L, H;
            L = float.Parse(Console.ReadLine());
            H = float.Parse(Console.ReadLine());

            float re = Delta(L,H);
            Console.WriteLine(re);
            return re;

        }
    }
}
