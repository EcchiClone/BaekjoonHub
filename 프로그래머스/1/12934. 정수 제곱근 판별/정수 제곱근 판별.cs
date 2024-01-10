using System;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        
        if(Math.Sqrt(n)%1==0){
            answer = ((long)Math.Sqrt(n)+1) * ((long)Math.Sqrt(n)+1);
        }
        else answer = -1;
        
        return answer;
    }
}