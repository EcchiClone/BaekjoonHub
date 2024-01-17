using System;
using System.Linq;

public class Solution {
    public string solution(string X, string Y) {
        string answer = "";
        // 2중 for문(O(N^2))은 시간복잡도가 초과할 것 처럼 보임.
        // X와 Y에 각각 나타나는 0~9 갯수 세서, 공통숫자 사용하여 짝꿍 수 구축
        int[] xNumber = new int[]{0,0,0,0,0,0,0,0,0,0}; // 0 ~ 9
        int[] yNumber = new int[]{0,0,0,0,0,0,0,0,0,0}; 
        
        foreach(char c in X) xNumber[int.Parse(c.ToString())]++;
        foreach(char c in Y) yNumber[int.Parse(c.ToString())]++;
        
        for(int i=9;i>=0;i--){
            // 시간초과 나서 while문에서 if문으로 바꿈
            int repeat = Math.Min(xNumber[i],yNumber[i]);
            answer += string.Concat(Enumerable.Repeat(i.ToString(), repeat));
        }
        if(answer=="") answer = "-1";
        if(answer[0]=='0') answer = (int.Parse(answer)).ToString();
        
        return answer;
    }
}