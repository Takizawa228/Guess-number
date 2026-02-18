using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameNum
{
    public class Player
    {
        public string name;
        public int age;
        public int health;

        public Player() {
            name = "TEST";
            age = 1;
            health = 3;
        }
        public Player(string name, int age, int health)
        {
            this.name = name;
            this.age = age;
            this.health = health;
        }
        public void Print()
        {
            Console.WriteLine(name + age + health);
        }
    }
}
