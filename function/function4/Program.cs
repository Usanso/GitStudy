using System.Numerics;

namespace function4
{
    // 📌 문제 5단계: 클래스와 함수 활용

    //Player 클래스를 만들어 체력(HP)을 관리하는 프로그램을 작성하시오.
    //Player 클래스는 HP 속성을 가진다.
    //TakeDamage(int damage) 함수는 체력을 감소시킨다.
    //Main() 에서 플레이어를 생성하고, 체력을 100으로 설정한 후, 데미지를 20 입힌 뒤 현재 체력을 출력

    //🔹 예시 출력:
    //초기 체력: 100
    //데미지를 입었습니다! 현재 체력: 80

    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }

    public class Player
    {
        public string Name { get; set; }
    }
}

