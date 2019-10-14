using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace test1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "\0";
            bool isStr = false;
             Computer computer = new Computer();
            Console.WriteLine("请输入两个数以及要进行的操作（+，-，*，/）或两个字符串以及要进行的操作（+,-）");
            try
            {   a = Console.ReadLine();
                computer.x = double.Parse(a);
                isStr =false;
            }
            catch
            {
                try
                {
                    computer.str1 =a;
                    isStr = true;
                }
                catch
                {
                    Console.WriteLine("输入数据时出错！");
                }
            
            }
     

            if (isStr == false)
            {
                string b = Console.ReadLine();
                computer.y = double.Parse(b);
                computer.z = Console.ReadLine();
                computer.show();
                computer.Equals(computer.x, computer.y);
                switch (computer.z)
                {
                    case "+": computer.add(computer.x, computer.y);
                        break;
                    case "-": computer.minus(computer.x, computer.y);
                        break;
                    case "*": computer.multiply(computer.x, computer.y);
                        break;
                    case "/": computer.divide(computer.x, computer.y);
                        break;
                    default: Console.WriteLine("输入的操作符号有误");
                        break;
                }
            }
            else
            {
                computer.str2 = Console.ReadLine();
                computer.p = Console.ReadLine();
                   computer.show1();
                   switch (computer.p)
                   {  case "+":computer.Connect(computer.str1,computer.str2);
                           break;
                     case "-": computer.remove(computer.str1, computer.str2);
                           break;
                     default: Console.WriteLine("输入的操作符号有误");
                           break;
                   }
            }
        }
    }
    class Computer
    {
        public double x;
        public double y;
        public string z,str1,str2,p;
        public void show()//计算器
        {
            Console.WriteLine("第一个数:{0}", x);
            Console.WriteLine("第二个数:{0}", y);
            Console.WriteLine("执行的操作{0}", z);
        }
        public void show1()//字符操作
        {
            Console.WriteLine("第一个字符串:{0}", str1);
            Console.WriteLine("第二个字符串:{0}",str2);
            Console.WriteLine("执行的操作{0}", p);
        }
        public void Equals(double x, double y)
        {
            if (x == y)
                Console.WriteLine("这两个数相等");
            else
                Console.WriteLine("这两个数不相等");
        }
        public void add(double x, double y)//加
        { Console.WriteLine("相加的结果是{0}", x + y); 
        }
        public void minus(double x, double y)//减
        { Console.WriteLine("相减的结果是{0}", x - y);
        }
        public void multiply(double x, double y)//乘
        { Console.WriteLine("相乘的结果是{0}", x * y);
        }
        public void divide(double x, double y)//除
        { Console.WriteLine("相除的结果是{0}", x / y); 
        }
        public void Connect(string str1,string str2)//字符串连接
        {  Console.WriteLine("连接后为{0}", str1 + str2);  
        }
        public void remove(string str1, string str2)//字符串去除
        {   string temp = str1;
            Console.WriteLine("连接后为{0}", temp.Replace(str2, ""));
        }
    }
}

