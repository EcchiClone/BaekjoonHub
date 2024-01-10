using System;

public class Solution {
    public int solution(int n) {
        
        int answer = 0;
        
        string nStr = n.ToString();
        
        foreach(char c in nStr){
            
            answer += int.Parse(c.ToString());
            
        }
        
        return answer;
    }
}