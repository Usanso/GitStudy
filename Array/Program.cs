namespace Array
{
    internal class Program
    {
        // Level 1: 배열의 합 구하기
        // 정수 배열이 주어졌을 때, 배열의 모든 원소의 합을 구하는 프로그램을 작성하시오.
        // int[] numbers = { 1, 2, 3, 4, 5 };
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 4, 5};
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum = sum + numbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
