using System;

namespace Array_4
{
    internal class Program
    {
        // Level 5: 두 배열의 교집합 구하기
        // 두 개의 정수 배열이 주어졌을 때, 두 배열의 공통된 원소(교집합)를 찾는 프로그램을 작성하시오.
        // 입력 예시: int[] arr1 = { 1, 2, 3, 4, 5 }; int[] arr2 = { 3, 4, 5, 6, 7 };
        // 출력 예시: 교집합 3 4 5

        static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 3, 4, 5, 6, 7 };
            Console.Write("교집합 : ");

            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1 [i] == arr2[j])
                    {
                        Console.Write(arr1[i]);
                    } 
                }
            }

        }
    }
}
