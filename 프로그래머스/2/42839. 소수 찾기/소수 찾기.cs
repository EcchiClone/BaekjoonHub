using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string numbers) {
        int answer = 0;
        
        // Sol. 해시 세트에 조합을 보관하여, 소수 갯수 Count
        HashSet<int> numberSet = new HashSet<int>();

        // 1. 주어진 숫자로 만들 수 있는 모든 숫자조합 생성
        GenerateNumbers("", numbers, numberSet);

        // 2. 생성된 숫자 중 소수의 개수를 세기
        foreach(int number in numberSet) {
            if(IsPrime(number)) {
                answer++;
            }
        }
        
        return answer;
    }
    
    // 숫자 조합 생성, 재귀함수
    private void GenerateNumbers(string prefix, string numbers, HashSet<int> numberSet) {
        int n = numbers.Length;
        if (!string.IsNullOrEmpty(prefix)) {
            numberSet.Add(int.Parse(prefix));
        }
        for(int i = 0; i < n; i++) {
            GenerateNumbers(prefix + numbers[i], numbers.Substring(0, i) + numbers.Substring(i+1, n-i-1), numberSet);
        }
    }

    // 소수 판별
    private bool IsPrime(int number) {
        if(number < 2) return false;
        for(int i = 2; i * i <= number; i++) {
            if(number % i == 0) return false;
        }
        return true;
    }
}