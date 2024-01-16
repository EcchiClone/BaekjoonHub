using System;
using System.Linq;
using System.Collections.Generic;


public class Solution {
    public int solution(int k, int m, int[] score) {
        
        int answer = 0;
        int remainder = 0;
        
        for(int i=k;i>=1;i--){
            int scoreIAppleCount = score.Count(x => x == i) + remainder;
            answer += ((scoreIAppleCount/m) * i * m);
            remainder = scoreIAppleCount%m;
        }
        return answer;
    }
}