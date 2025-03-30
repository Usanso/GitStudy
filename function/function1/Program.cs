namespace function1
{
    internal class Program
    {
        //        2단계: 매개변수와 반환값
        //📌 문제:
        //두 개의 정수를 입력받아 두 수의 합을 반환하는 함수를 작성하시오.

        //함수 이름: AddNumbers

        //매개변수: int a, int b

        //반환값: 두 숫자의 합 (int)

        //Main() 에서 두 숫자를 입력받고, AddNumbers() 를 호출하여 결과를 출력

        static void Main(string[] args)
        {
            Console.WriteLine("첫번째 값");
            int a = int.Parse(Console.ReadLine());
            
            Console.WriteLine("두번째 값");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("두 값의 합");
            Console.WriteLine( AddNumbers(a, b));
        }

        static int AddNumbers(int 첫번쨰, int 두번째)
        {
            int 합 = 첫번쨰+두번째;
            return 합;
        }
    }
}
