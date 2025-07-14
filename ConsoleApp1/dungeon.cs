using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ConsoleApp1;
using Rtaninventory;
using RtanMonster;
using Rtanstat;
using Rtanstore;
using static Rtanitem.RtanItem;

namespace Rtandungeon
{
    internal class Dungeon
    {
        public void Battle()
        {
            Random random = new Random();

            while (true)
            {
                Console.WriteLine("던전");
                for (int i = 0; i < 3; i++)
                {
                    int index = random.Next(Village.monsterList.Count);
                    Monster monster = Village.monsterList[index];

                    Console.WriteLine($"Lv.3 {monster.MonsterName} HP {monster.MonsterHP}");
                }
                Console.WriteLine("[내정보]");
                Console.WriteLine("LV. 01");
                Console.WriteLine("chad( 전사 )");

                Console.WriteLine("1. 공격)");

                string userChoice = Console.ReadLine();
                Console.WriteLine(" ");

                switch (userChoice)
                {
                    case "1":
                        Stat.Displaystat();
                        break;

                    default:
                        Console.WriteLine("잘못된 입력입니다");
                        break;
                }
            }
        }
    }
}

