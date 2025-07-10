using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rtanitem
{
    public class RtanItem
    {
        public abstract class Item
        {
            public string NameTxt { get; set; }//이걸로 이름을 임력
            public string Explanation { get; set; }//이걸로 설명을 출력

            public int Price { get; set; }
            public Item(string name, string explanation, int price)
            {
                NameTxt = name;
                Explanation = explanation;
                Price = price;
            }

            public virtual void Name() => Console.Write(NameTxt); //이름 메소드
            public virtual void Ex() => Console.Write(Explanation); // 설명 메소드
        }

        public class Weapon : Item
        {
            public int Atkstat { get; set; } //공격력 지정

            public Weapon(string name, string explanation, int atkstat, int Price)
                : base(name, explanation ,Price)
            {
                Atkstat = atkstat;
            }
            public void Stat() => Console.Write("공격력: " + Atkstat);
        }
        public class Armor : Item
        {
            public int Defstat { get; set; } //방어력 지정

            public Armor(string name, string explanation, int defstat, int Price)
                : base(name, explanation, Price)
            {
                Defstat = defstat;
            }
            public void Stat() => Console.Write("방어력: " + Defstat);
        }
        

    }
}
