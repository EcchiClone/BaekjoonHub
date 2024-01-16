using System;
using System.Collections.Generic;
public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
        List<int> list = new List<int>();
        
        for(int i=0;i<score.Length;i++){
            if(list.Count<k){
                list.Add(score[i]);
                list.Sort();
            }
            else if(list[0]<score[i]){
                list[0]=score[i];
                list.Sort();
            }
            answer[i] = list[0];
        }
        
        return answer;
    }
}