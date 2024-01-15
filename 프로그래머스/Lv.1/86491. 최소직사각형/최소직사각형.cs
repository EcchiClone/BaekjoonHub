using System;

public class Solution {
    public int solution(int[,] sizes) {
        int answer = 0;
        
        int maxOfMax = 0;
        int maxOfMin = 0;
        
        for (int i = 0; i < sizes.GetLength(0); i++) {
            int iMax = Math.Max(sizes[i,0],sizes[i,1]);
            int iMin = Math.Min(sizes[i,0],sizes[i,1]);
            maxOfMax = (iMax>maxOfMax)?iMax:maxOfMax;
            maxOfMin = (iMin>maxOfMin)?iMin:maxOfMin;
        }
        
        answer = maxOfMax*maxOfMin;
        
        return answer;
    }
}