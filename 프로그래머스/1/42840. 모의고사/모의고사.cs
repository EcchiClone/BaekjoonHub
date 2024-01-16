using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] answers) {
        int[] answer = new int[]{};
        
        int[] user0 = new int[]{1,2,3,4,5};
        int[] user1 = new int[]{2,1,2,3,2,4,2,5};
        int[] user2 = new int[]{3,3,1,1,2,2,4,4,5,5};
        int[] score = new int[]{0,0,0};
        
        for(int i=0;i<answers.Length;i++){
            if(answers[i]==user0[i%user0.Length]) score[0]++;
            if(answers[i]==user1[i%user1.Length]) score[1]++;
            if(answers[i]==user2[i%user2.Length]) score[2]++;
        }
        // 최댓값 찾기
        int maxScore = 0;
        foreach (int item in score) {
            if (item > maxScore) {
                maxScore = item;
            }
        }
        // 최댓값을 가지는 사람 모두 찾기
        List<int> answerList = new List<int>();
        for (int i = 0; i < score.Length; i++) {
            if (score[i] == maxScore) {
                answerList.Add(i+1);
            }
        }
        answer = answerList.ToArray();
        return answer;
    }
}