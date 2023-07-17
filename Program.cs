using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UB20230717
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //배열(맵) 1 > 벽, 0 > 필드
            int[,] map ={
                            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 },
                            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                            { 1, 0, 0, 0, 1, 1, 0, 0, 0, 1 },
                            { 1, 0, 0, 0, 1, 1, 0, 0, 0, 1 },
                            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                            { 1, 0, 0, 0, 0, 0, 0, 0, 0, 1 },
                            { 1, 1, 1, 1, 1, 1, 1, 1, 1, 1 }
             };


            //플레이어의 x, y 변수값 생성
            int playerX = 1;
            int playerY = 1;

            //시작하자마자 바로 실행시키기
            for (int y = 0; y < 10; y++)
            {
                for (int x = 0; x < 10; x++)
                {
                    //플레이어의 XY변수값과 좌표x,y의 값이 동일할때 그 좌표에 P생성
                    if (playerX == x && playerY == y)
                    {
                        Console.Write("P" + " ");
                    }
                    else if (map[y, x] == 1)
                    {
                        Console.Write("*" + " ");
                    }
                    else if (map[y, x] == 0)
                    {
                        Console.Write(" " + " ");
                    }

                }
                Console.WriteLine();
            }


            //while 반복문으로 항상 참인 상태를 유지시켜 계속 출력하게 설정
            while (true)
            {
                //키입력을 할수있는 변수 설정
                ConsoleKeyInfo info = Console.ReadKey(true);

                //switch문에 각각 키를 입력하면 그 값이 출력 되게 설정
                switch (info.Key)
                {
                    //케이스1 : 방향키왼쪽
                    //PlayerX의 위치를 x좌표 기준 --로 이동시킴
                    case ConsoleKey.LeftArrow:
                        //플레이어P가 왼쪽으로 이동하는 좌표에 0이 있을경우 이동가능
                        //0이 아닐경우 이동X
                        if (map[playerY, playerX - 1] == 0)
                        {
                            playerX--;
                        }
                        break;
                    //케이스2 : 방향키오른쪽
                    //PlayerX의 위치를 x좌표 기준 ++로 이동시킴
                    case ConsoleKey.RightArrow:
                        //플레이어P가 오른쪽으로 이동하는 좌표에 0이 있을경우 이동가능
                        //0이 아닐경우 이동X
                        if (map[playerY, playerX + 1] == 0)
                        {
                            playerX++;
                        }
                        break;
                    //케이스3 : 방향키위쪽
                    //PlayerX의 위치를 y좌표 기준 --로 이동시킴
                    case ConsoleKey.UpArrow:
                        //플레이어P가 위로 이동하는 좌표에 0이 있을경우 이동가능
                        //0이 아닐경우 이동X
                        if (map[playerY - 1, playerX] == 0)
                        {
                            playerY--;
                        }
                        break;
                    //케이스4 : 방향키아래쪽
                    //PlayerX의 위치를 y좌표 기준 ++로 이동시킴
                    case ConsoleKey.DownArrow:
                        //플레이어P가 아래으로 이동하는 좌표에 0이 있을경우 이동가능
                        //0이 아닐경우 이동X
                        if (map[playerY + 1, playerX] == 0)
                        {
                            playerY++;
                        }
                        break;
                }
                //P의 좌표를 변경시키면서 새로운 그림이 나오는데
                //과거 그림을 클리어 시키면서 이동하는 것처럼 보이게 함
                Console.Clear();


                // for반복문으로
                //  한줄 출력 -> 다음줄 출력 -> 다음줄 출력 ->....
                // if문으로 맵에 있는 x y 좌표가 1일경우 *로 표시 -> 벽
                // 0일경우 빈칸으로 표시 -> 필드


                for (int y = 0; y < 10; y++)
                {
                    for (int x = 0; x < 10; x++)
                    {
                        //플레이어의 XY변수값과 좌표x,y의 값이 동일할때 그 좌표에 P생성
                        if (playerX == x && playerY == y)
                        {
                            Console.Write("P" + " ");
                        }
                        else if (map[y, x] == 1)
                        {
                            Console.Write("*" + " ");
                        }
                        else if (map[y, x] == 0)
                        {
                            Console.Write(" " + " ");
                        }

                    }
                    Console.WriteLine();
                }


            }
        }
    }
}
