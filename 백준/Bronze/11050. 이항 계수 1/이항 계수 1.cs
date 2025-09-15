using System;
class Program
{
    static void Main(string[] args)
    {
        // 입력
        string[] input = Console.ReadLine().Split(); // 한 줄 입력?
        int N = int.Parse(input[0]);
        int K = int.Parse(input[1]);
        
        // 로직
        int result = 1;
        for(int i=N; i>N-K; i--) result *= i;
        for(int i=1; i<=K; i++) result /= i;
        
        // 출력
        Console.WriteLine(result);
    }
}