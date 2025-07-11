using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using Rtanitem;
using static Rtanitem.RtanItem;


namespace Rtaninventory
{

    internal class inventory
    {
        public static void boy()
        {
            Console.Clear();
            while (true)
            {
                Console.Clear();
                Console.WriteLine("인벤토리");
                Console.WriteLine("보유 중인 아이템을 관리할 수 있습니다.");
                Console.WriteLine("[아이템 목록]");
                for (int i = 0; i < Village.inventoryList.Count; i++)
                {
                    Item item = Village.inventoryList[i];
                    string statInfo = "";
                    string equipMark = (item == Village.Equipitem) ? "[E] " : "";

                    if (item is Weapon weapon)
                    {
                        statInfo = $"공격력: {weapon.Atkstat}";
                    }
                    else if (item is Armor armor)
                    {
                        statInfo = $"방어력: {armor.Defstat}";
                    }
                    Console.WriteLine($"{equipMark}-{item.NameTxt}|{item.Explanation}|{statInfo}");
                }
                //아이템 리스트 불러오기
                Console.WriteLine("1. 장착 관리");
                //장착 아이템 불러오기
                Console.WriteLine("0. 나가기");
                Console.WriteLine(" ");
                Console.WriteLine("원하시는 행동을 입력해주세요.");
                string say = Console.ReadLine();
                switch (say)
                {
                    case "1":
                        inventory.EquipMenu();
                        break;
                    case "0":
                        return;
                        break;
                    default:
                        Console.WriteLine("잘못된 입력입니다");
                        break;
                }

            }
        }
        public static void EquipMenu()
        {
            Console.Clear();
            Console.WriteLine("인벤토리 - 장착 관리");
            for (int i = 0; i < Village.inventoryList.Count; i++)
            {
                Item item = Village.inventoryList[i];
                string statInfo = "";
                string equipMark = (item == Village.Equipitem) ? "[E] " : "";

                if (item is Weapon weapon)
                    statInfo = $"공격력: {weapon.Atkstat}";
                else if (item is Armor armor)
                    statInfo = $"방어력: {armor.Defstat}";

                Console.WriteLine($"{i}. {equipMark}- {item.NameTxt} | {item.Explanation} | {statInfo}");
            }

            Console.Write("장착할 아이템 번호를 입력하세요 (취소는 Enter): ");
            string say = Console.ReadLine();

            if (int.TryParse(say, out int selectedIndex) &&
                    selectedIndex >= 0 && selectedIndex < Village.inventoryList.Count)
            {
                if(Village.inventoryList[selectedIndex] != Village.Equipitem)
                {
                    Village.Equipitem = Village.inventoryList[selectedIndex];
                    Console.WriteLine($"{Village.Equipitem.NameTxt}을(를) 장착했습니다!");
                }

                else 
                {
                    Village.Equipitem = null;
                    Console.WriteLine($"{Village.inventoryList[selectedIndex].NameTxt}을(를) 장착 해제했습니다!");
                }
            }

            else
            {
                Console.WriteLine("잘못된 입력입니다.");
            }

            Console.WriteLine("\n엔터를 누르면 인벤토리로 돌아갑니다.");
            Console.ReadLine();
        }

    }
}

