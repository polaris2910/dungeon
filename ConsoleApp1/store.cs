using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;
using Rtaninventory;
using Rtanitem;
using Rtanstat;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static Rtanitem.RtanItem;
using static Rtanstat.stat;

namespace Rtanstore
{
    internal class store
    {
        public static void buy()
        {
            Console.Clear();
            while (true)
            {
                Console.WriteLine("상점");
                Console.WriteLine("필요한 아이템을 얻을 수 있는 상점입니다.");
                Console.WriteLine(" ");
                Console.WriteLine("[보유 골드]");
                Console.WriteLine(data.Gold + "G");
                Console.WriteLine("[아이템 목록]");
                for (int i = 0; i < Village.storeList.Count; i++)
                {
                    Item item = Village.storeList[i];
                    string statInfo = "";//스텟인포가져오고

                    if (item is Weapon weapon)//이프문 무기
                    {
                        statInfo = $"공격력: {weapon.Atkstat}";
                    }
                    else if (item is Armor armor)//이프문 방어력
                    {
                        statInfo = $"방어력: {armor.Defstat}";
                    }
                    Console.WriteLine($"- {item.NameTxt}|{item.Explanation}|{statInfo}|{item.Price}G");
                }
                Console.WriteLine(" ");
                Console.WriteLine("1.아이템 구매");
                Console.WriteLine("0. 나가기");

                Console.WriteLine("원하시는 행동을 입력해주세요.");
                string say = Console.ReadLine();
                switch (say)
                {
                    case "1":
                        store.BuyMenu();
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
        public static void BuyMenu()
        {
            Console.Clear();
            Console.WriteLine("상점 - 아이템 구매");
            Console.WriteLine(" ");
            Console.WriteLine("[보유 골드]");
            Console.WriteLine(data.Gold + "G");
            for (int i = 0; i < Village.storeList.Count; i++)
            {
                Item item = Village.storeList[i];
                string statInfo = "";

                if (item is Weapon weapon)
                    statInfo = $"공격력: {weapon.Atkstat}";
                else if (item is Armor armor)
                    statInfo = $"방어력: {armor.Defstat}";

                Console.WriteLine($"{i}. - {item.NameTxt} | {item.Explanation} | {statInfo}|{item.Price}G");
            }

            Console.Write("구매할 아이템 번호를 입력하세요 (취소는 Enter): ");
            string say = Console.ReadLine();

            if (int.TryParse(say, out int selectedIndex) &&
                selectedIndex >= 0 && selectedIndex < Village.storeList.Count)
            {
                Item selectedItem = Village.storeList[selectedIndex];
                if (data.Gold >= selectedItem.Price)
                {
                    if (!Village.inventoryList.Contains(selectedItem))
                    {
                        data.Gold -= selectedItem.Price;
                        Village.inventoryList.Add(selectedItem);
                        Console.WriteLine($"구매를 완료했습니다.");
                    }
                    else
                    {
                        Console.WriteLine($"이미 구매한 아이템입니다");
                    }
                }
                else
                {
                    Console.WriteLine("Gold가 부족합니다.");
                }
            }
            else
            {
                Console.WriteLine("잘못된 입력입니다.");
            }

            Console.WriteLine("\n엔터를 누르면 상점으로 돌아갑니다.");
            Console.ReadLine();
        }
    }
}


