using System;

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        int num = n;
        string triple="";
        // 3진법으로 변환
        while(num!=0){
            triple = (num%3).ToString() + triple;
            num /= 3;
        }
        int mul=1;
        foreach(char c in triple){
            answer += mul*int.Parse(c.ToString());
            mul*=3;
        }
        
        
        return answer;
    }
}