using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using static Rtanitem.RtanItem;

namespace Rtanstat
{
    public static class Stat
    {
        
        public static StatData data = new StatData();
       
        public static void say()
        {
            Console.Clear();
            Console.WriteLine("상태 보기");
            Console.WriteLine("캐릭터의 정보가 표시됩니다.");
            Console.WriteLine(" ");
            Console.WriteLine("LV. 01");
            Console.WriteLine("chad( 전사 )");
            int plusAtk = 0;
            int plusDef = 0;

            if (Village.Equipitem is Weapon weapon)
            {
                plusAtk = weapon.Atkstat;
            }
            else if (Village.Equipitem is Armor armor)
            {
                plusDef = armor.Defstat;
            }//장비 능력치 가져오기

            string atklook = plusAtk > 0 ? $"{data.atk} (+{plusAtk})" : data.atk.ToString();
            string deflook = plusDef > 0 ? $"{data.def} (+{plusDef})" : data.def.ToString();
            Console.WriteLine("공격력 : " + atklook);
            Console.WriteLine("방어력 : " + deflook);
            Console.WriteLine("체 력 :" + data.HP);
            Console.WriteLine("Gold : " + data.Gold + "G");
            Console.WriteLine(" ");
            Console.WriteLine("0. 나가기");

            Console.WriteLine("원하시는 행동을 입력해주세요.");
            string say = Console.ReadLine();
            if (say == "0")
            {
                return;
            }
        }
        public class StatData
        {
            public int Gold = 1500000;
            public int atk = 10;
            public int def = 5;
            public int HP = 100;
        }


    }
}

