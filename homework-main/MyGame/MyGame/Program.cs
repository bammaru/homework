using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyGame
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo cki;
            int x = 10, y = 2; //#의 시작위치

            while (true)//무한루프    
            {
                //화면초기화
                Console.Clear();
                ForegroundColor = ConsoleColor.Green;
                WriteLine(" 방향키 빨리 누르기");
                ForegroundColor = ConsoleColor.White;
                WriteLine("===================");
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("       설명");
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("       시작");
                ForegroundColor = ConsoleColor.White;
                WriteLine("===================");            

                //커서를 x,y의 위치로 이동
                Console.SetCursorPosition(x, y);

                //#을 입력
                Console.Write('◁');

                //누르는 키를 입력받아 true값이면 넣음
                cki = Console.ReadKey(true);

                




                switch (cki.Key)
                {

                    case ConsoleKey.UpArrow: y--; break;

                    case ConsoleKey.DownArrow: y++; break;

                    case ConsoleKey.Enter: return;
                }
            }

            
            ForegroundColor = ConsoleColor.White;
            WriteLine("================기본적인 룰================");
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("화면에 나오는 패턴에 맞춰서 방향키를 이용해");
            WriteLine("          30초 안에 다 치면 클리어     ");
            WriteLine(" ");
            WriteLine("목숨은 3번 주어지며 3번 틀렸을경우 게임오버");
            ForegroundColor = ConsoleColor.White;
            WriteLine("===========================================");
            WriteLine(" ");
            WriteLine(" ");
            WriteLine(" ");
            WriteLine("시작하실려면 Enter키를 눌러주세요.");







            /*
            
            ConsoleKeyInfo cki;
            int x = 16, y = 2; //#의 시작위치

            while (true)//무한루프    
            {
                //화면초기화
                Console.Clear();
                WriteLine("난이도를 선택해주세요.");
                WriteLine("===========================================");
                WriteLine("1 (짧고 쉬움) ");
                WriteLine("2 (짧고 좀 복잡) ");
                WriteLine("3 (보통) ");
                WriteLine("4 (길지만 좀 쉬움) ");
                WriteLine("5 (길고 복잡함) ");
                WriteLine("===========================================");            

                //커서를 x,y의 위치로 이동
                Console.SetCursorPosition(x, y);

                //#을 입력
                Console.Write('◁');

                //누르는 키를 입력받아 true값이면 넣음
                cki = Console.ReadKey(true);


                switch (cki.Key)
                {

                    case ConsoleKey.UpArrow: y--; break;

                    case ConsoleKey.DownArrow: y++; break;

                    case ConsoleKey.Enter: return;
                }
            }
           
            */

        }




        /*
        
        1 : ←←→←↓↓↑←↓→
        2 : →↓←→↑↑↓→←↑
        3 : ↑↓→→←↓→↑←↑↓→→↑←
        4 : ↑↑←↓→→↓←↑→↑↓←→↓→↑←→↓
        5 : ↓←↓→↓↑←↓→→↓←↑←→↓↑→↓←
        ♥
        ♡

                WriteLine("======================================================");
                WriteLine("난이도 :");
                WriteLine("목숨 : ❤❤❤");
                WriteLine(" ");
                WriteLine("↓←↓→↓↑←↓→→↓←↑←→↓↑→↓←");
                WriteLine(" ");
                WriteLine("입력받는곳 ");
                WriteLine(" ");
                WriteLine("======================================================");



        */


        /*
        
        ■■■■■■■
        ■
        ■
         ■■■■■■
                    ■
                    ■
        ■          ■
          ■■■■■


             ■  ■
            ■   ■
           ■    ■
          ■     ■
         ■      ■ 
        ■■■■■■■
                 ■
                 ■
                 ■

        ■■■■■■
                   ■
                   ■
                   ■
        ■■■■■■
                   ■
                   ■
                   ■
        ■■■■■■

          ■■■■
         ■       ■
        ■         ■
                  ■
                ■
              ■
            ■
         ■
        ■■■■■■

              ■
            ■■
          ■  ■
              ■
              ■
              ■
              ■
              ■
          ■■■■■




        */

    }



}
