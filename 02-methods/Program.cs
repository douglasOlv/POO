using System;

namespace _02_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            People obj = new People();
            obj.introduce();
            obj.introduce("Douglas");
            obj.introduce("Douglas", 26);
        }
    }
}
