using System.Diagnostics;

namespace function2
{
    internal class Program
    {
        //3단계: 몫과 나머지 반환하기
        //📌 문제:
        //두 개의 정수를 입력받아 나눗셈의 몫과 나머지를 반환하는 함수를 작성하시오.
        //함수 이름: DivideNumbers
        //매개변수: int a, int b
        //반환값: (int 몫, int 나머지) → 튜플 반환 사용
        //Main() 에서 두 숫자를 입력받고, DivideNumbers() 를 호출하여 결과를 출력

        //🔹 예시 입력:
        //10 3

        //🔹 예시 출력:
        //몫: 3, 나머지: 1
        static void Main(string[] args)
        {
            Console.WriteLine("첫번째 값 : ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("두번째 값 : ");
            int b = int.Parse(Console.ReadLine());
            (int, int) tuple = (a, b);

            var c = DivideNumbers(tuple);
            Console.WriteLine($"몫: {c.Item1}, 나머지: {c.Item2}");

        }
        static (int, int) DivideNumbers((int,int) numbers)
        {
           

            int share = numbers.Item1 / numbers.Item2;
            int residuum = numbers.Item1 % numbers.Item2;

            return (share, residuum);
        }

    }
}

