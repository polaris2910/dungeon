using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RtanMonster
{
    public class Monster
    {
       
            public string MonsterName { get; set; }
            public int MonsterHP { get; set; }
            public int MonsterAtk { get; set; }
            public Monster(string MonsterName, int MonsterHP, int MonsterAtk)
            {
                this.MonsterName = MonsterName;
                this.MonsterHP = MonsterHP;
                this.MonsterAtk = MonsterAtk;
            }

            public virtual void ShowName() => Console.Write(MonsterName); //이름 메소드
            public virtual void ShowHP() => Console.Write(MonsterHP); //HP
            public virtual void ShowAtk() => Console.Write(MonsterAtk);// 공격력
        }
    }

