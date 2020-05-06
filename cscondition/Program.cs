using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cscondition
{
    class Program
    {
        static void Main(string[] args)
        {
            //짝수, 홀수 구분
            Console.Write("숫자 입력 : ");
            int input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("짝수입니다!");
            }else
            {
                Console.WriteLine("홀수입니다!");
            }

            // 현재 시간 구하기
            Console.Write(DateTime.Now.Year + "년");
            Console.Write(DateTime.Now.Month + "월");
            Console.Write(DateTime.Now.Day + "일");
            Console.Write(DateTime.Now.Hour + "시");
            Console.Write(DateTime.Now.Minute + "분");
            Console.WriteLine(DateTime.Now.Second + "초");

            // 오전과 오후 구분
            if(DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침 먹을 시간입니다");
            } else { 
                if(DateTime.Now.Hour < 15)
                {
                    Console.WriteLine("점심 먹을 시간입니다.");
                }
                else
                {
                    Console.WriteLine("저녁 먹을 시간입니다.");
                }
                
            }
        }
    }
}
