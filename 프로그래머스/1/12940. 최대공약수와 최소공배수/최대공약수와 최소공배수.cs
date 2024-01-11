using System;
public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        
        // 최대공약수 구현
        int num1 = n;
        int num2 = m;
        while(true){
            int max = Math.Max(num1,num2);
            int min = Math.Min(num1,num2);
            if(max%min==0){
                answer[0] = min;
                break;
            }
            num1 = max%min;
            num2 = min;
        }
        
        answer[1] = n*m/answer[0];
        
        return answer;
    }
}