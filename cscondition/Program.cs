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
            Console.Write(DateTime.Now.Second + "초");

            // 오전과 오후 구분
            if(DateTime.Now.Hour < 12)
            {
                Console.WriteLine("오전입니다");
            } else { 
                Console.WriteLine("오후입니다.");
            }
        }
    }
}
