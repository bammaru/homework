using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace game1
{
        static void Main(String[] args);


        public static class StartMenu
        {
            public static int posY = 0;
            public static bool _letFinish = false;
            static bool _letOut = false;
            static int _Hp = 5;

            public static void WaitMenu()
            {
                SetCursorPosition(5, 2);
                Console.ForegroundColor = ConsoleColor.Green;
                WriteLine("=========================================");
                Console.ForegroundColor = ConsoleColor.White;
                SetCursorPosition(20, 3);
                WriteLine("선택지를 고른 후 엔터를 눌러주세요.");
                SetCursorPosition(5, 4);
                Console.ForegroundColor = ConsoleColor.Green;
                WriteLine("=========================================");
                SetCursorPosition(25, 6);
                WriteLine($"Hp : {_Hp}");
                SetCursorPosition(15, 8);
                WriteLine("설명듣기");
                SetCursorPosition(15, 9);
                WriteLine("시작하기");
                SetCursorPosition(15, 10);
                WriteLine("종료");

                do
                {
                    for (int k = 0; k < 4; k++)
                    {
                        SetCursorPosition(10, k + 8);
                        Write("  ");
                    }
                    SetCursorPosition(10, posY + 8);
                    Write("▶");

                    ConsoleKeyInfo key = Console.ReadKey(true);


                    switch (key.Key)
                    {
                        case ConsoleKey.UpArrow:
                            posY--;
                            if (posY < 0)
                            {
                                posY = 3;
                            }
                            break;
                        case ConsoleKey.DownArrow:
                            posY++;
                            if (posY > 3)
                            {
                                posY = 0;
                            }
                            break;
                        case ConsoleKey.Enter:
                            _letOut = true;
                            break;
                    }

                } while (!_letOut);

                Clear();
                itSelect();

                _letOut = false;

                if (_Hp <= 0)
                {
                    Clear();
                    SetCursorPosition(5, 2);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                    Console.ForegroundColor = ConsoleColor.White;
                    SetCursorPosition(20, 3);
                    WriteLine("게임 오버");
                    SetCursorPosition(5, 4);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    WriteLine("ㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡㅡ");
                    Console.ForegroundColor = ConsoleColor.White;
    
                    ReadKey();
                    _letFinish = true;
                }

            }
                private static void itSelect()
                {
                    switch (posY)
                    {
                        case 0: //설명듣기
                            Explanation.Initialize(ref _Hp);
                            break;
                        case 1: //시작하기
                            Start.Initialize(ref _Hp);
                            break;
                        case 2: //종료
                            _letFinish = false;
                            break;

                    }
                }
        }     
        public static class Explanation
        {
            public static void Initialize(ref int hp)
            {

            }
        }

        public static class Start
        {
            public static void Initialize(ref int hp)
            {

            }
        }

    
}






        
        
       








   



/*
 
처음 시작화면
=========================================
선택지를 고른 후 스페이스바를 눌러주세요.
=========================================
1. 설명듣기
2. 시작하기

*/