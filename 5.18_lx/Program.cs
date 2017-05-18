using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._18_lx
{

    //定义结构
    struct Person {
        public string name;
        public int age;
        public double height;
        public Gender sex;
    }

    //枚举
    enum Gender {
        nan,nv
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region 

            Person p;
            p.name = "张三";
            p.age = 23;
            p.height = 180;
            p.sex = Gender.nan;
           // string str = Convert.ToString(p.sex)==Convert.ToString(Gender.nan)?"男":"女";

            //string str=p.sex==0?"男":"女";
           // string str = p.sex == Gender.nan ? "男" : "女";

            Person p1;
            p1.name = "李四";
            p1.age = 22;
            p1.height = 170;
            p1.sex = Gender.nv;

            Console.WriteLine("姓名:{0},年龄：{1},身高：{2},性别：{3}",p.name,p.age,p.height, p.sex == Gender.nan ? "男" : "女");

            Console.WriteLine("姓名:{0},年龄：{1},身高：{2},性别：{3}", p1.name, p1.age, p1.height, p1.sex == Gender.nan ? "男" : "女");

            Console.ReadKey(); 
            #endregion
        }
    }
}
