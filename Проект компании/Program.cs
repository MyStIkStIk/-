using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Проект_компании
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Organization apple = new Organization("Apple inc.", 435976.564M);
            apple.doljnosti = new Post[5];
            apple.doljnosti[0] = new Post("Cherkis", "Vladislav", "TeamLead", 2500M);
            apple.doljnosti[1] = new Post("Lyashuk", "Vladislav", "Junior", 1000M);
            apple.doljnosti[2] = new Post("Novak", "Roman", "Senior", 2000M);
            apple.doljnosti[3] = new Post("Cook", "Tim", "Director", 4000M);
            apple.doljnosti[4] = new Post("Lion", "Alex", "Middle", 1500M);
            apple.doljnosti[1].ReturnInfo();
            apple.RabotaMesac("new app");
            apple.RabotaMesac("clean smth");

        }
    }
}
