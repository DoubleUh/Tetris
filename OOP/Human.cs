using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    abstract class Human
    {
        public int age;
        public int height;

        public void Set(int age)
        {
            this.age = age;
        }
        public void Set(int age, int height)
        {
            this.age = age;
            this.height = height;
        }

        //public virtual void Write()
        //{
        //    Console.WriteLine($"age: {age}, height: {height}");
        //}

        public abstract void Write();

    }
}
