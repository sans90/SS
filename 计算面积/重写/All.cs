using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 虚函数重写
{
    class All
    {
        static void Main()
        {
            All[] alls = new All[4];
            int a = int.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    alls[0] = new circle();
                    alls[0].GD();
                    break;
                case 2:
                    alls[1] = new Cube();
                    alls[1].GD();
                    break;
                case 3:
                    alls[2] = new delta();
                    alls[2].GD();
                    break;
            }

            Console.ReadLine();
        }

        virtual public float GD()
        {           
            return 0;
        }

        public void W()
        {

        }
    }
}
