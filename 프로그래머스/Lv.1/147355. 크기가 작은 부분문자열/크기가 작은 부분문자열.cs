using System;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        
        for (int i = 0; i<t.Length-p.Length+1; i++){
            if(long.Parse(t.Substring(i,p.Length))<=long.Parse(p)) answer++;
        }
        
        return answer;
    }
}