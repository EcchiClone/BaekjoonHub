using System;
using System.Linq;
using System.Collections.Generic;

class Solution
{
    public int solution(int[] nums)
    {
        int answer = 0;
        
        // nums를 리스트로 바꾸고, 정렬, 최대값 셋 더하여 나올 수 있는 소수 범위의 최댓값 찾기
        List<int> numsList = nums.ToList();
        numsList.Sort();
        int sumMax = numsList[numsList.Count-1] + numsList[numsList.Count-2] + numsList[numsList.Count-3];
        
        // 소수 판별 리스트 작성. 최대 sumMax(문제 조건 상으론 최악의 경우 2997).
        List<bool> isPrimeNumber = new List<bool>(Enumerable.Repeat(true, sumMax + 1));
        for(int i=2;i<=(int)Math.Sqrt(sumMax);i++){
            if(isPrimeNumber[i]==false) continue;
            isPrimeNumber[i] = true;
            for(int j=2;j*i<=sumMax;j++) isPrimeNumber[j*i] = false;
        }
        
        // 세 수 더하여, 소수로 판정 시, answer++;
        for(int i=0;i<nums.Length-2;i++)
            for(int j=i+1;j<nums.Length-1;j++)
                for(int k=j+1;k<nums.Length;k++)
                    if(isPrimeNumber[nums[i]+nums[j]+nums[k]]==true) answer++;

        return answer;
    }
}