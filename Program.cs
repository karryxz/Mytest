using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 简单计算器
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer();
            Console.WriteLine("请输入两个数以及要进行的操作（+，-，*，/）");
            try
            {
                string a = Console.ReadLine();
                computer.x = double.Parse(a);
                string b = Console.ReadLine();
                computer.y = double.Parse(b);
                computer.z = Console.ReadLine();
            }
           catch
            {
              
               Console.WriteLine("输入数据时出错！");
               Console.ReadKey();
            }
            
                computer.show();
                computer.Equals(computer.x, computer.y);
            switch(computer.z)
            {  case "+": computer.add(computer.x, computer.y);
                         break;
               case "-":computer.minus(computer.x, computer.y);
                         break;
               case "*" :computer.multiply(computer.x, computer.y);
                         break;
               case "/" :computer.divide(computer.x, computer.y);
                         break;
               default: Console.WriteLine("输入的操作符号有误");
                         break;
            }
        }
    }
    class Computer
    {
        public double x;
        public double y;
        public string z;
        public void show()
        { Console.WriteLine("第一个数:{0}",x);
          Console.WriteLine("第二个数:{0}",y);
          Console.WriteLine("执行的操作{0}",z);
        }
        public void Equals(double x,double y)
        {
            if (x == y)
                Console.WriteLine("这两个数相等");
            else
                Console.WriteLine("这两个数不相等");
        }
        public void add(double x,double y)
        { Console.WriteLine("相加的结果是{0}",x+y); }
        public void minus(double x, double y)
        { Console.WriteLine("相减的结果是{0}", x-y); }
        public void multiply(double x, double y)
        { Console.WriteLine("相乘的结果是{0}", x*y); }
        public void divide(double x, double y)
        { Console.WriteLine("相除的结果是{0}", x/y); }
    }
}
