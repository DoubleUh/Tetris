using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Officer : Human
    {
        public string rank;

        public Officer(int age, string rank)
        {
            this.age = age;
            this.rank = rank;
        }

        public override void Write()
        {
            Console.WriteLine($"age: {age}, height: {height}, rank: {rank}");
        }

    }


}
