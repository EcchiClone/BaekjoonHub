using System;
using System.Linq;

public class Solution {
    public string solution(string s) {
        
        string answer = "";
        bool isUpper = true;
        int diff = (int)'a' - (int)'A';
        // answer = diff.ToString(); // 차이 32임을 확인함.
        
        foreach(char c in s){
            if(c==' '){
                answer += c.ToString();
                isUpper = true;
                continue;
            }
            else if(isUpper){
                if('a'<=c && c<='z') answer += ((char)((int)c-diff)).ToString();
                else answer += c.ToString();
            }
            else{
                if('A'<=c && c<='Z') answer += ((char)((int)c+diff)).ToString();
                else answer += c.ToString();
            }
            isUpper = !isUpper;
        }
        return answer;
    }
}