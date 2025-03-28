namespace Array_2
{
    internal class Program
    {
        /// Level 3: 배열 뒤집기
        /// 정수 배열이 주어졌을 때, 배열의 원소를 거꾸로 정렬하는 프로그램을 작성하시오.
        /// 입력 : int[] numbers = { 3, 8, 1, 7 };
        /// 출력 : 뒤집힌 배열: 7 1 8 3

        static void Main(string[] args)
        {
            int[] numbers = { 3, 8, 1, 7 };
            int a; // 스왑용 변수

            for (int i = 0; i < numbers.Length/2; i++)
            {
                a = numbers[i];
                numbers[i] = numbers[numbers.Length - (i+1)];
                numbers[numbers.Length - (i + 1)] = a;
            }
            
            // foreach 포이츠 int num 안으로 초기화 넘버스(배열)
            foreach(int num in numbers)
            {
                Console.Write(num);
            }
        }
    }
}
