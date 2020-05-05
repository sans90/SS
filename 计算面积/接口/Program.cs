using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 接口
{
    class Program
    {
        static void Main()
        {
            Definition definition = new Definition();
            definition.Fun();
            Console.ReadLine();
        }

    }

    class Definition
    {
        public Definition()
        {
            Console.WriteLine("1-3");
        }

        public void Fun()
        {
            int num = int.Parse(Console.ReadLine());
            switch (num)
            {
                case 1:
                    Cube cube = new Cube();
                    float Re= cube.CalculatedAreaCube(float.Parse(Console.ReadLine()));

                    Console.WriteLine("结果： "+Re);
                    break;
                case 2:
                    Delta delta = new Delta();
                    float H = float.Parse(Console.ReadLine());
                    float L = float.Parse(Console.ReadLine());

                    float Result = delta.CalculatedAreaDelta(L, H);
                    Console.WriteLine(Result);
                    break;
                case 3:
                    Circle circle = new Circle();
                    float result = circle.CalculatedAreaCircle(float.Parse(Console.ReadLine()),0);

                    Console.WriteLine(result);
                    break;
            }
        }
    }

    class Cube : ICalculatedArea
    {
        public Cube()
        {
            Console.Write("输入X: ");
        }

        public float CalculatedAreaCube(float X)
        {
            return X * X;   
        }

        public float CalculatedAreaCircle(float R, int i = 0)
        {
            throw new NotImplementedException();
        }

        public float CalculatedAreaDelta(float X, float H)
        {
            throw new NotImplementedException();
        }
    }
    class Delta : ICalculatedArea
    {
        public Delta()
        {
            Console.WriteLine("H and L");
        }

        public float CalculatedAreaCube(float X)
        {
            return 0;
        }

        public float CalculatedAreaCircle(float R, int i = 0)
        {
            return 0;
        }

        public float CalculatedAreaDelta(float X, float H)
        {
            return X*H/2;
        }
    }
    class Circle : ICalculatedArea
    {
        public Circle()
        {
            Console.WriteLine("R");
        }

        public float CalculatedAreaCircle(float R, int i = 0)
        {
            return (float)(Math.PI * R * R);
        }

        public float CalculatedAreaCube(float X)
        {
            throw new NotImplementedException();
        }

        public float CalculatedAreaDelta(float X, float H)
        {
            throw new NotImplementedException();
        }
    }

    interface ICalculatedArea
    {
        float CalculatedAreaCube(float X);
        float CalculatedAreaDelta(float X,float H);
        float CalculatedAreaCircle(float R,int i=0);
    }
}
