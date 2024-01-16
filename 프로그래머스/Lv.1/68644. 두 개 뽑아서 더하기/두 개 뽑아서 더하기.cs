using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        int[] answer = new int[] {};
        // 동적관리를 위한 List<int> 사용
        List<int> answerList = new List<int>();
        
        for(int i=0; i<numbers.Length-1; i++){
            for(int j=i+1; j<numbers.Length; j++){
                int sum = numbers[i]+numbers[j];
                if (!answerList.Contains(sum)) {
                    answerList.Add(sum);
                }
            }
        }
        answerList.Sort();
        answer = answerList.ToArray();
        return answer;
    }
}