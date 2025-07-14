using System.Xml.Linq;
using Rtaninventory;
using Rtanitem;
using Rtanstat;
using Rtanstore;
using Rtandungeon;
using static Rtanitem.RtanItem;


namespace ConsoleApp1
{
    public class Village
    {
        
        public static List<Item> inventoryList = new List<Item>();
        public static List<Item> storeList = new List<Item>();
        public static Item Equipitem = null;
        static void Main(string[] args)
        {
            Console.Clear();
            //아이템 리스트 추가 상점과 인벤토리 따로따로 제작


            storeList.Add(new Weapon("듀얼디스크", "어쨋든 1대1은 받아줄것 같습니다.", 100,500));
            storeList.Add(new Weapon("청동도끼", "어디선가 사용됐던거 같은 도끼입니다.", 5,600));
            storeList.Add(new Armor("수련자 갑옷", "수련에 도움을 주는 갑옷입니다.", 9,5022));
            storeList.Add(new Armor("티셔츠", "수련에 도움을 주지 않는 옷입니다.", 9, 5022));

            inventoryList.Add(new Armor("강철 갑옷", "튼튼하게 몸을 보호해주는 갑옷", 80,1545));
            inventoryList.Add(new Weapon("스파르타의 창", "스파르타의 전사들이 사용했다는 전설의 창입니다", 7,1321));
            inventoryList.Add(new Armor("무쇠갑옷", "무쇠로 만들어져 튼튼한 갑옷입니다.", 5,1321));
            inventoryList.Add(new Weapon("낡은 검", "쉽게 볼 수 있는 낡은 검 입니다.", 2,666));


            while (true)
            {
                //코드를 시작하자
                Console.WriteLine("스파르타 마을에 오신 여러분 환영합니다.");
                Console.WriteLine("이곳에서 던전으로 들어가기전 활동을 할 수 있습니다.");
                Console.WriteLine();
                Console.WriteLine("1. 상태 보기");
                Console.WriteLine("2. 인벤토리");
                Console.WriteLine("3. 상점");
                Console.WriteLine("4. 던전");
                Console.WriteLine("원하시는 행동을 입력해주세요.");


                string how = Console.ReadLine();
                Console.WriteLine(" ");

                switch (how)
                {
                    case "1":
                        stat.say();
                        break;
                    case "2":
<<<<<<< Updated upstream
                        inventory.boy();
=======
                        Inventory inventory = new Inventory();
                        inventory.Pouch();
>>>>>>> Stashed changes
                        break;
                    case "3":
                        store.buy();
                        break;
                    case "4":
                        dungeon.Dungeon();
                        break;
                    default:
                        Console.WriteLine("잘못된 입력입니다");
                        break;

                }
                Console.WriteLine("엔터를 눌러 마을로 되돌아 가세요.");
                Console.ReadLine();
            }
        }
    }

    
}
