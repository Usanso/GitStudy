namespace Array_3
{
    internal class Program
    {
        // Level 4: 중복 제거 후 정렬하기
        // 정수 배열이 주어졌을 때, 중복된 원소를 제거하고 오름차순으로 정렬하는 프로그램을 작성하시오.
        // int[] numbers = { 4, 2, 7, 2, 1, 4, 5, 7 };
        // 정렬된 배열: 1 2 4 5 7

        // 정렬기능 Array.Sort() 메서드
        static void Main(string[] args)
        {
            int[] numbers = { 4, 2, 7, 2, 1, 4, 5, 7 };

            int[] numArray = numbers.Distinct().ToArray(); // 중복값 제거
            Array.Sort(numArray); // 순서 오름차순 정렬

            foreach (int i in numArray)
            {
                Console.Write(i);
            }

        }
    }
}
