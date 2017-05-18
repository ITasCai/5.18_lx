using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._18_lx
{
    class Method
    {
        static void Main(string[] args)
        {
            GetName("狗蛋");
            
        }

        /// <summary>
        /// 一个有参数的方法
        /// </summary>
        /// <param name="name">姓名</param>
        static void GetName(string name) {
            Console.WriteLine("欢迎您：{0}",name);
        }
    }
}
