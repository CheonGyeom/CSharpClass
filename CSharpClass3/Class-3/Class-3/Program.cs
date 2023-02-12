using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 키 입력하는 부분

            //ConsoleKeyInfo cski;

            //int x = 10;
            //int y = 10;

            //while (true)
            //{
            //    Console.Clear();

            //    Console.SetCursorPosition(x, y);

            //    Console.Write("#");

            //    cski = Console.ReadKey(true);

            //    switch(cski.Key)
            //    {
            //        case ConsoleKey.LeftArrow:
            //            x--;
            //            break;
            //        case ConsoleKey.RightArrow:
            //            x++;
            //            break;
            //        case ConsoleKey.UpArrow:
            //            y--;
            //            break;
            //        case ConsoleKey.DownArrow:
            //            y++;
            //            break;
            //    }
            //}

            #endregion

            #region 1번째 과제

            /*
            int num;
            string input;

            for (int i = 0; i == 0;)
            {
                input = System.Console.ReadLine();

                num = Convert.ToInt32(input);

                if (num == 10)
                {
                    break;
                }
                else if ((num % 2) == 0)
                {
                    continue;
                }
                else
                {
                    System.Console.WriteLine("다음 숫자 입력");
                }
            }
            */

            #endregion

            //Student[] students = new Student[2];

            //for (int i = 0; i < 2; i++)
            //{
            //    students[i] = new Student();
            //    students[i].InputStudentIndoData();
            //}


            //Food foods = new Food();
            //foods.InputFoodsList();


            //OutputZodiacSign zodiac = new OutputZodiacSign();
            //zodiac.InputBirth();


            //Game game = new Game();
            //game.InputGame();


            //Classes myNewClass = new Classes();
            //myNewClass.WriteSchoolInfo("단봉초등학교");


            //KoreanFood koreanfood = new KoreanFood();
            //ChinessFood chinessfood = new ChinessFood();
            //WesternFood westurnfood = new WesternFood();

            //System.Console.WriteLine("한식 식당, 중식 식당, 양식 식당");
            //System.Console.WriteLine("몇 번째 식당에 가시겠습니까?");

            //int choice = Convert.ToInt32(System.Console.ReadLine());

            //switch (choice)
            //{
            //    case 1:
            //        koreanfood.MenuSetting();
            //        koreanfood.ShowMenu();
            //        break;
            //    case 2:
            //        chinessfood.MenuSetting();
            //        chinessfood.ShowMenu();
            //        break;
            //    case 3:
            //        westurnfood.MenuSetting();
            //        westurnfood.ShowMenu();
            //        break;
            //}

            //System.Console.WriteLine();
            //System.Console.WriteLine("몇 번 음식을 드시겠습니까?");
            //int inputMenu = Convert.ToInt32(System.Console.ReadLine()) - 1;
            //koreanfood.OderMenu(inputMenu);


            //Library library = new Library();

            //int countBookNumber = 0;
            //do
            //{
            //    library.InputBooksData(countBookNumber);
            //    countBookNumber++;
            //} while (library.AskKeepPutData());


            Classes classes = new Classes();

            int countBookNumber = 0;
            do
            {
                classes.InputStudentsData(countBookNumber);
                countBookNumber++;
            } while (classes.AskKeepPutData());
            
        }
    }
 

    class Food
    {
        public string[] foodList;

        public void InputFoodsList()
        {

            foodList = new string[5];
            for (int i = 0; i < 5; i++)
            {
                System.Console.Write("음식 이름 : ");
                foodList[i] = System.Console.ReadLine();
            }
            System.Console.WriteLine();

            AddInputFood();

            WriteLineFoodInfo();
        } // 음식 이름 입력 메소드

        public void AddInputFood()
        {
            string newFood;
            System.Console.Write("추가 음식 이름 : ");
            newFood = System.Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                if (foodList[i] == newFood)
                {
                    foodList[i] = "";
                    break;
                }
            }
        } // 추가 음식 이름 입력, 비교 메소드

        public void WriteLineFoodInfo()
        {
            System.Console.Write($"남은 음식 : ");
            for (int i = 0; i < 5; i++)
            {
                {
                    System.Console.Write($"{foodList[i]} , ");
                }
            }
        } // 남은 음식 출력 메소드
    }

    class OutputZodiacSign
    {
        public int birth;

        public void InputBirth()
        {
            System.Console.WriteLine("출생 연도를 입력해주세요.");
            birth = Convert.ToInt32(System.Console.ReadLine());

            MyZodiacSign();
        }

        public void MyZodiacSign()
        {
            string zodiacSign = "";

            switch (birth % 12)
            {
                case 0:
                    zodiacSign = "원숭이";
                    break;
                case 1:
                    zodiacSign = "닭";
                    break;
                case 2:
                    zodiacSign = "개";
                    break;
                case 3:
                    zodiacSign = "돼지";
                    break;
                case 4:
                    zodiacSign = "쥐";
                    break;
                case 5:
                    zodiacSign = "소";
                    break;
                case 6:
                    zodiacSign = "호랑이";
                    break;
                case 7:
                    zodiacSign = "토끼";
                    break;
                case 8:
                    zodiacSign = "용";
                    break;
                case 9:
                    zodiacSign = "뱀";
                    break;
                case 10:
                    zodiacSign = "말";
                    break;
                case 11:
                    zodiacSign = "양";
                    break;
            }

            System.Console.WriteLine($"당신은 만 {2023 - birth}세 {zodiacSign} 띠입니다.");
            
        }
    }

    class Game
    {
        public string[] gameList = new string[5] { "배틀그라운드", "오버워치", "리니지", "스타크래프트", "오버쿡드" };

        public void InputGame()
        {
            string inputGame;
            System.Console.Write("게임 이름 : ");
            inputGame = System.Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                if (gameList[i] == inputGame)
                {
                    System.Console.Write("게임을 보유하고 있습니다!");
                    break;
                }
                else if (i == 4)
                {
                    System.Console.Write("게임을 보유하고 있지 않습니다.");
                    break;
                }
            }
        }
    }



  


    class Restaurant
    {
        // 메뉴와 가격
        protected int[] price;
        protected string[] menu;

        // 돈 계산
        protected void TakePay(int money)
        {
            System.Console.WriteLine($"{money}원을 지불했습니다.");

        }
        // 주문
        public void OderMenu(int number)
        {
            System.Console.WriteLine($"주문 : {menu[number]}");
            TakePay(price[number]);
        }

        // 메뉴판 보여주기
        public void ShowMenu()
        {
            System.Console.WriteLine($"종류 : ");
            for (int i = 0; i < menu.Count(); i++)
            {
                System.Console.Write($"{menu[i]}, ");
            }
        }
    }

    class KoreanFood : Restaurant
    {
        public void MenuSetting()
        {
            menu = new string[2];
            menu[0] = "국밥";
            menu[1] = "수육";

            price = new int[2];
            price[0] = 8000;
            price[1] = 20000;
        }
    }
    class ChinessFood : Restaurant
    {
        public void MenuSetting()
        {
            menu = new string[2];
            menu[0] = "탕수육";
            menu[1] = "마라탕";

            price = new int[2];
            price[0] = 6000;
            price[1] = 17000;
        }
    }
    class WesternFood : Restaurant
    {
        public void MenuSetting()
        {
            menu = new string[2];
            menu[0] = "파스타";
            menu[1] = "필라프";

            price = new int[2];
            price[0] = 6500;
            price[1] = 6000;
        }
    }


    class Book
    {
        public string title;
        public string writer;
        public string company;
    }

    class Library
    {
        Book[] books = new Book[99];

        public void InputBooksData(int BookCount)
        {
            books[BookCount] = new Book();

            System.Console.Write("제목 : ");
            books[BookCount].title = System.Console.ReadLine();

            System.Console.Write("저자 : ");
            books[BookCount].writer = System.Console.ReadLine();

            System.Console.Write("출판사 : ");
            books[BookCount].company = System.Console.ReadLine();
            System.Console.Write("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        }

        public bool AskKeepPutData()
        {
            System.Console.Write("계속 입력할까요? (y/n) : ");
            string userAnser = System.Console.ReadLine();

            if (userAnser == "y")
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SearchTitle()
        {

        }
    }

    class Student
    {
        public int classNumber;
        public string name;
    }

    class Classes
    {
        Student[] students = new Student[99];

        public void InputStudentsData(int StudentsCount)
        {
            students[StudentsCount] = new Student();

            System.Console.Write("반 : ");
            students[StudentsCount].classNumber = Convert.ToInt32(System.Console.ReadLine());

            System.Console.Write("이름 : ");
            students[StudentsCount].name = System.Console.ReadLine();

            System.Console.Write("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
        }
        public bool AskKeepPutData()
        {
            System.Console.Write("계속 입력할까요? (y/n) : ");
            string userAnser = System.Console.ReadLine();

            if (userAnser == "y")
            {
                return true;
            }
            else
            {
                CallClassStudents();
                return false;
            }
        }

        public void CallClassStudents()
        {
            System.Console.Write("몇 반을 호출할까요?");
            int classNum = Convert.ToInt32(System.Console.ReadLine());

            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] == null)
                {
                    break;
                }
                else if (students[i].classNumber == classNum)
                {
                    System.Console.WriteLine(students[i].name);
                }
            }
        }
    }
}
