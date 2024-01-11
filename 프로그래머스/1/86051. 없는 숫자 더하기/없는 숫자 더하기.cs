using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = -1;
        
        answer = 45;
        
        for(int i=0; i<numbers.Length; i++){
            answer -= numbers[i];
        }
        
        return answer;
    }
}