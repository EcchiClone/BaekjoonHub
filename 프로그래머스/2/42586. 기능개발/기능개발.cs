using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        int[] answer = new int[] {};
        List<int> answerList = new List<int>();
        // 솔루션.
        // 현재 pivot의 남은일수 계산하여 전체에 반영
        // 현재 pivot부터 진행도 progress 100 이상인 작업 모두 사출
        // pivot 이동 후 반복
        int[] updatingProgresses = (int[])progresses.Clone();
        
        int pivot = 0;
        
        while(pivot<progresses.Length){
            // 남은일수 계산
            int nokoriProgress = 100 - updatingProgresses[pivot];
            int nokoriDays = nokoriProgress/speeds[pivot];
            if(nokoriProgress%speeds[pivot]!=0) nokoriDays++;
            // 모든 작업에 해당 일자로 업데이트
            for(int i = pivot; i < updatingProgresses.Length ; i++){
                updatingProgresses[i] += nokoriDays * speeds[i];
            }
            // 작업도 100 이상인 연속된 작업들 모두 사출
            answerList.Add(0);
            while(pivot<progresses.Length){
                Console.WriteLine(pivot);
                if(updatingProgresses[pivot]>=100){
                    answerList[answerList.Count-1]++;
                    pivot++;
                }
                else{
                    break;
                }
            }
        }
        
        answer = answerList.ToArray();
        
        return answer;
    }
}