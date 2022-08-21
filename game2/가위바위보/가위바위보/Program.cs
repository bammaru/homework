using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace 가위바위보
{
    class Program
    {
        static void Main(string[] args)
        {

            bool cheak = true;
            while (cheak)
            {

                Random rand = new Random();
                int aiChoice = rand.Next(0, 3); // 0~2사이의 랜덤 값


                ForegroundColor = ConsoleColor.Green;
                WriteLine("가위바위보 게임");
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("0 = 가위 ");
                WriteLine("1 = 바위 ");
                WriteLine("2 = 보 ");
                ForegroundColor = ConsoleColor.White;
                WriteLine("0(가위) 1(바위) 2(보) 중 선택해서 쓰세요");

                // 0:가위, 1:바위 2:보



                int choice = Convert.ToInt32(ReadLine());

                switch (choice)  //사람의 선택
                {
                    default:
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("패를 선택하시지 않았습니다.");
                        break;

                    case 0:
                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("                                                           ");
                        WriteLine("                     ■■■                                  ");
                        WriteLine("                   ■      ■                  ■■■ ");
                        WriteLine("                 ■        ■                ■      ■  ");
                        WriteLine("                 ■        ■              ■        ■");
                        WriteLine("                 ■          ■            ■        ■");
                        WriteLine("                 ■          ■          ■          ■");
                        WriteLine("                 ■          ■          ■        ■ ");
                        WriteLine("                 ■          ■        ■          ■");
                        WriteLine("                   ■        ■        ■        ■");
                        WriteLine("                   ■        ■      ■■        ■");
                        WriteLine("                     ■        ■    ■        ■");
                        WriteLine("                     ■        ■  ■          ■");
                        WriteLine("             ■■■■■        ■  ■        ■");
                        WriteLine("           ■        ■  ■■■■■          ■");
                        WriteLine("     ■■■■        ■■          ■■■   ■");
                        WriteLine("   ■      ■        ■                  ■■");
                        WriteLine(" ■        ■        ■                    ■ ");
                        WriteLine(" ■        ■        ■                      ■■■");
                        WriteLine("   ■        ■        ■■■■                  ■");
                        WriteLine("   ■        ■          ■    ■■                ■");
                        WriteLine("     ■        ■        ■      ■                ■");
                        WriteLine("     ■        ■        ■    ■■                ■");
                        WriteLine("     ■■        ■      ■    ■                  ■");
                        WriteLine("     ■  ■    ■■■■■      ■                  ■");
                        WriteLine("     ■    ■■■                                ■");
                        WriteLine("       ■                                        ■");
                        WriteLine("       ■                                      ■");
                        WriteLine("         ■                                  ■");
                        WriteLine("         ■                                ■");
                        WriteLine("           ■■                          ■");
                        WriteLine("               ■■                ■■■");
                        WriteLine("                   ■■■■■■■■");
                        WriteLine("                                                       ");

                        ForegroundColor = ConsoleColor.White;
                        WriteLine("당신의 선택은 가위입니다.");
                        break;
                    case 1:
                        ForegroundColor = ConsoleColor.Blue;
                        WriteLine("                                                                    ");
                        WriteLine("                      ■■    ■■■■    ■■■");
                        WriteLine("                ■■■    ■■        ■■      ■■");
                        WriteLine("        ■■  ■          ■        ■              ■");
                        WriteLine("    ■■    ■          ■          ■              ■");
                        WriteLine("    ■      ■        ■          ■                  ■");
                        WriteLine("  ■      ■■        ■          ■                    ■");
                        WriteLine("  ■      ■          ■    ■■■■■■■■■■          ■");
                        WriteLine("■        ■        ■    ■                    ■■      ■");
                        WriteLine("■        ■        ■    ■                        ■    ■");
                        WriteLine("■        ■        ■    ■                          ■  ■");
                        WriteLine("■        ■        ■    ■                            ■■");
                        WriteLine("■        ■          ■    ■                            ■");
                        WriteLine("  ■        ■        ■      ■■                          ■");
                        WriteLine("  ■        ■        ■          ■■■                    ■");
                        WriteLine("  ■        ■          ■        ■    ■                    ■");
                        WriteLine("■  ■        ■          ■■■■                            ■");
                        WriteLine("■    ■        ■      ■                                    ■");
                        WriteLine("■      ■    ■  ■■■                                      ■");
                        WriteLine("  ■      ■■                                                ■");
                        WriteLine("  ■                                                        ■");
                        WriteLine("  ■                                                      ■");
                        WriteLine("    ■                                                    ■");
                        WriteLine("    ■                                                  ■");
                        WriteLine("      ■                                              ■");
                        WriteLine("        ■                                          ■");
                        WriteLine("          ■■                                    ■");
                        WriteLine("              ■                                ■");
                        WriteLine("              ■                              ■");
                        WriteLine("              ■                              ■");
                        WriteLine("                ■                            ■");
                        WriteLine("                ■                            ■");
                        WriteLine("                  ■■■■■■■■■■■■■■");
                        WriteLine("                                                                 ");

                        ForegroundColor = ConsoleColor.White;
                        WriteLine("당신의 선택은 바위입니다.");
                        break;
                    case 2:

                        ForegroundColor = ConsoleColor.Yellow;
                        WriteLine("                                                              ");
                        WriteLine("                              ■■■");
                        WriteLine("            ■■■          ■      ■");
                        WriteLine("          ■      ■        ■      ■       ■■■");
                        WriteLine("          ■      ■        ■      ■     ■      ■");
                        WriteLine("            ■      ■      ■      ■     ■    ■");
                        WriteLine("■■■■    ■        ■    ■      ■   ■      ■");
                        WriteLine("■    ■      ■      ■    ■      ■   ■    ■");
                        WriteLine("  ■    ■      ■      ■  ■      ■ ■      ■");
                        WriteLine("  ■      ■    ■      ■  ■      ■ ■      ■");
                        WriteLine("  ■      ■    ■      ■  ■      ■■     ■");
                        WriteLine("    ■      ■  ■      ■  ■      ■       ■");
                        WriteLine("      ■    ■■■        ■■             ■");
                        WriteLine("      ■                                   ■");
                        WriteLine("        ■                                 ■       ■■■■");
                        WriteLine("          ■                               ■  ■■       ■");
                        WriteLine("          ■                               ■■           ■");
                        WriteLine("          ■                                          ■■");
                        WriteLine("            ■                                    ■■");
                        WriteLine("            ■                                  ■");
                        WriteLine("            ■                              ■■");
                        WriteLine("              ■                            ■");
                        WriteLine("                ■                        ■");
                        WriteLine("                  ■                  ■■");
                        WriteLine("                    ■■■■■■■■■");
                        WriteLine("                                                                  ");


                        ForegroundColor = ConsoleColor.White;
                        WriteLine("당신의 선택은 보입니다.");
                        break;
            

                }
                switch (aiChoice)  //컴퓨터의 선택
                {
                    case 0:

                        ForegroundColor = ConsoleColor.Red;
                        WriteLine("                                                           ");
                        WriteLine("                     ■■■                                  ");
                        WriteLine("                   ■      ■                  ■■■ ");
                        WriteLine("                 ■        ■                ■      ■  ");
                        WriteLine("                 ■        ■              ■        ■");
                        WriteLine("                 ■          ■            ■        ■");
                        WriteLine("                 ■          ■          ■          ■");
                        WriteLine("                 ■          ■          ■        ■ ");
                        WriteLine("                 ■          ■        ■          ■");
                        WriteLine("                   ■        ■        ■        ■");
                        WriteLine("                   ■        ■      ■■        ■");
                        WriteLine("                     ■        ■    ■        ■");
                        WriteLine("                     ■        ■  ■          ■");
                        WriteLine("             ■■■■■        ■  ■        ■");
                        WriteLine("           ■        ■  ■■■■■          ■");
                        WriteLine("     ■■■■        ■■          ■■■   ■");
                        WriteLine("   ■      ■        ■                  ■■");
                        WriteLine(" ■        ■        ■                    ■ ");
                        WriteLine(" ■        ■        ■                      ■■");
                        WriteLine("   ■        ■        ■■■■                  ■");
                        WriteLine("   ■        ■          ■    ■■                ■");
                        WriteLine("     ■        ■        ■      ■                ■");
                        WriteLine("     ■        ■        ■    ■■                ■");
                        WriteLine("     ■■        ■      ■    ■                  ■");
                        WriteLine("     ■  ■    ■■■■■      ■                  ■");
                        WriteLine("     ■    ■■■                                ■");
                        WriteLine("       ■                                        ■");
                        WriteLine("       ■                                      ■");
                        WriteLine("         ■                                  ■");
                        WriteLine("         ■                                ■");
                        WriteLine("           ■■                          ■");
                        WriteLine("               ■■                ■■■");
                        WriteLine("                   ■■■■■■■■");
                        WriteLine("                                                       ");

                        ForegroundColor = ConsoleColor.White;

                        WriteLine("컴퓨터의 선택은 가위입니다.");
                        break;
                    case 1:

                        ForegroundColor = ConsoleColor.Blue;
                        WriteLine("                                                                    ");
                        WriteLine("                      ■■    ■■■■    ■■■");
                        WriteLine("                ■■■    ■■        ■■      ■■");
                        WriteLine("        ■■  ■          ■        ■              ■");
                        WriteLine("    ■■    ■          ■          ■              ■");
                        WriteLine("    ■      ■        ■          ■                  ■");
                        WriteLine("  ■      ■■        ■          ■                    ■");
                        WriteLine("  ■      ■          ■    ■■■■■■■■■■          ■");
                        WriteLine("■        ■        ■    ■                    ■■      ■");
                        WriteLine("■        ■        ■    ■                        ■    ■");
                        WriteLine("■        ■        ■    ■                          ■  ■");
                        WriteLine("■        ■        ■    ■                            ■■");
                        WriteLine("■        ■          ■    ■                            ■");
                        WriteLine("  ■        ■        ■      ■■                          ■");
                        WriteLine("  ■        ■        ■          ■■■                    ■");
                        WriteLine("  ■        ■          ■        ■    ■                    ■");
                        WriteLine("■  ■        ■          ■■■■                            ■");
                        WriteLine("■    ■        ■      ■                                    ■");
                        WriteLine("■      ■    ■  ■■■                                      ■");
                        WriteLine("  ■      ■■                                                ■");
                        WriteLine("  ■                                                        ■");
                        WriteLine("  ■                                                      ■");
                        WriteLine("    ■                                                    ■");
                        WriteLine("    ■                                                  ■");
                        WriteLine("      ■                                              ■");
                        WriteLine("        ■                                          ■");
                        WriteLine("          ■■                                    ■");
                        WriteLine("              ■                                ■");
                        WriteLine("              ■                              ■");
                        WriteLine("              ■                              ■");
                        WriteLine("                ■                            ■");
                        WriteLine("                ■                            ■");
                        WriteLine("                  ■■■■■■■■■■■■■■");
                        WriteLine("                                                                 ");

                        ForegroundColor = ConsoleColor.White;

                        WriteLine("컴퓨터의 선택은 바위입니다.");
                        break;
                    case 2:

                        ForegroundColor = ConsoleColor.Yellow;
                        WriteLine("                                                              ");
                        WriteLine("                              ■■■");
                        WriteLine("            ■■■          ■      ■");
                        WriteLine("          ■      ■        ■      ■       ■■■");
                        WriteLine("          ■      ■        ■      ■     ■      ■");
                        WriteLine("            ■      ■      ■      ■     ■    ■");
                        WriteLine("  ■■■    ■        ■    ■      ■   ■      ■");
                        WriteLine("■    ■      ■      ■    ■      ■   ■    ■");
                        WriteLine("■      ■      ■      ■  ■      ■ ■      ■");
                        WriteLine("  ■      ■    ■      ■  ■      ■ ■      ■");
                        WriteLine("  ■      ■    ■      ■  ■      ■■     ■");
                        WriteLine("    ■      ■  ■      ■  ■      ■       ■");
                        WriteLine("      ■    ■■■        ■■             ■");
                        WriteLine("      ■                                   ■");
                        WriteLine("        ■                                 ■       ■■■■");
                        WriteLine("          ■                               ■  ■■       ■");
                        WriteLine("          ■                               ■■           ■");
                        WriteLine("          ■                                          ■■");
                        WriteLine("            ■                                    ■■");
                        WriteLine("            ■                                  ■");
                        WriteLine("            ■                              ■■");
                        WriteLine("              ■                            ■");
                        WriteLine("                ■                        ■");
                        WriteLine("                  ■                  ■■");
                        WriteLine("                    ■■■■■■■■■");
                        WriteLine("                                                                  ");


                        ForegroundColor = ConsoleColor.White;

                        WriteLine("컴퓨터의 선택은 보입니다.");
                        break;
                }
                // 승리 무승부 패배
                int result = choice - aiChoice; // 가위바위보를 0.1.2 숫자로 생각 . 0:가위, 1:바위 2:보
                if (result == 0)
                {
                    ForegroundColor = ConsoleColor.Green;

                    WriteLine("무승부입니다");
                }
                else if ((result == 1) || (result == -2))
                {
                    ForegroundColor = ConsoleColor.Blue;

                    WriteLine("승리입니다");
                }
                else
                {
                    ForegroundColor = ConsoleColor.Red;

                    WriteLine("패배입니다");

                }
                
                ForegroundColor = ConsoleColor.Yellow;
                WriteLine("종료하시겠습니까?");
                ForegroundColor = ConsoleColor.White;
                WriteLine("종료하실려면 y를, 계속하실려면 아무키를 누르세요.");

                string next = Convert.ToString(ReadLine());

                if (string.Compare(next, "y") == 0)
                {
                    WriteLine("게임을 종료합니다.");
                    break;
                }
                else if (string.Compare(next, "n") == -1)
                {
                    WriteLine("다시 실행합니다");
                }
                
        
            }     
		}
    }
}



/*
                                                                    
                      ■■    ■■■■    ■■■
                ■■■    ■■        ■■      ■■
        ■■  ■          ■        ■              ■
    ■■    ■          ■          ■              ■
    ■      ■        ■          ■                  ■
  ■      ■■        ■          ■                    ■
  ■      ■          ■    ■■■■■■■■■■          ■
■        ■        ■    ■                    ■■      ■
■        ■        ■    ■                        ■    ■
■        ■        ■    ■                          ■  ■
■        ■        ■    ■                            ■■
■        ■          ■    ■                            ■  
  ■        ■        ■      ■■                          ■
  ■        ■        ■          ■■■                    ■
  ■        ■          ■        ■    ■                    ■
■  ■        ■          ■■■■                            ■
■    ■        ■      ■                                    ■  
■      ■    ■  ■■■                                      ■
  ■      ■■                                                ■ 
  ■                                                        ■
  ■                                                      ■
    ■                                                    ■
    ■                                                  ■
      ■                                              ■
        ■                                          ■
          ■■                                    ■
              ■                                ■ 
              ■                              ■
              ■                              ■
                ■                            ■  
                ■                            ■ 
                  ■■■■■■■■■■■■■■ 
                                                                      
 
 
 
                                                           
                     ■■■                                  
                   ■      ■                  ■■■ 
                 ■        ■                ■      ■  
                 ■        ■              ■        ■
                 ■          ■            ■        ■
                 ■          ■          ■          ■
                 ■          ■          ■        ■ 
                 ■          ■        ■          ■
                   ■        ■        ■        ■
                   ■        ■      ■■        ■  
                     ■        ■    ■        ■ 
                     ■        ■  ■          ■
             ■■■■■        ■  ■        ■
           ■        ■  ■■■■■          ■
     ■■■■        ■■          ■■■   ■
   ■      ■        ■                  ■■
 ■        ■        ■                    ■         
 ■        ■        ■                      ■■■
   ■        ■        ■■■■                  ■
   ■        ■          ■    ■■                ■
     ■        ■        ■      ■                ■
     ■        ■        ■    ■■                ■
     ■■        ■      ■    ■                  ■
     ■  ■    ■■■■■      ■                  ■
     ■    ■■■                                ■  
       ■                                        ■
       ■                                      ■
         ■                                  ■
         ■                                ■
           ■■                          ■  
               ■■                ■■■ 
                   ■■■■■■■■ 
                                                                 
 
 
 
 
                                                              
                              ■■■
            ■■■          ■      ■
          ■      ■        ■      ■       ■■■
          ■      ■        ■      ■     ■      ■
            ■      ■      ■      ■     ■    ■
■■■■    ■        ■    ■      ■   ■      ■  
■    ■      ■      ■    ■      ■   ■    ■
  ■    ■      ■      ■  ■      ■ ■      ■
  ■      ■    ■      ■  ■      ■ ■      ■
  ■      ■    ■      ■  ■      ■■     ■
    ■      ■  ■      ■  ■      ■       ■
      ■    ■■■        ■■             ■     
      ■                                   ■  
        ■                                 ■
        ■                               ■
          ■                             ■ 
          ■                             ■         ■■■■
          ■                               ■  ■■       ■
          ■                               ■■           ■
          ■                                          ■■
            ■                                    ■■   
            ■                                  ■  
            ■                              ■■
              ■                          ■
                ■                        ■
                  ■                  ■■
                    ■■■■■■■■■
 









 */