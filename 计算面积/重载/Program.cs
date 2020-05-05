using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace 重载
{

    class Program
    {
        //调用
        static void Main()
        {
            ConsoleColor consoleColor = Console.BackgroundColor;

            Console.WriteLine("1-3", consoleColor);
            CalculatedArea(Console.ReadLine());
            Console.ReadLine();
        }

        //定义


        //几何体
        static void CalculatedArea(string TypeArea)
        {

            switch (TypeArea)
            {
                case "1":

                    Console.WriteLine("输入边");
                    float X = float.Parse(Console.ReadLine());
                    float result1 = Computes(X);
                    Console.WriteLine(result1);
                    break;

                case "2":

                    Console.WriteLine("输入长");
                    float L = float.Parse(Console.ReadLine());
                    Console.WriteLine("输入高");
                    float H = float.Parse(Console.ReadLine());
                    float result0 = Computes(L, H);



                    Console.WriteLine(result0);

                    break;

                case "3":
                    Console.WriteLine("输入半径");

                    float r = float.Parse(Console.ReadLine());
                    float re = Computes(r, 0);
                    Console.WriteLine(re);
                    break;
            }
        }

        //正方形
        static float Computes(float Long)
        {
            float re = Long * Long;
            return re;
        }

        //三角形
        static float Computes(float Long, float Hight)
        {
            float result = Long * Hight / 2;
            return result;
        }

        //圆
        static float Computes(float r, int a = 0)
        {
            float result = (float)Math.PI * r;
            return result;
        }

    }
}