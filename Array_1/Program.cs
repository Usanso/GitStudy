namespace Array_1
{
    internal class Program
    {
        // Level 2: 최댓값과 최솟값 찾기
        // 정수 배열이 주어졌을 때, 배열 내 최댓값과 최솟값을 찾는 프로그램을 작성하시오.
        // int[] numbers = { 7, 2, 9, 4, 1, 5 };

        static void Main(string[] args)
        {
            int[] numbers = { 7, 2, 9, 4, 1, 5 };
            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }
            Console.WriteLine("최댓값 : {0}", max);

            int min = numbers[0];

            for(int i = 1;i < numbers.Length; i++)
            {
                if(numbers[i] < min)
                {
                    min = numbers[i];
                }
            }
            Console.WriteLine("최솟값 : {0}", min);
        }
    }
}
