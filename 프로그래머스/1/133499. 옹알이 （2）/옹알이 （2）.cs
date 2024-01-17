using System;

public class Solution {
    public int solution(string[] babbling) {
        int answer = 0;
        string[] babBase = new string[] {"aya", "ye", "woo", "ma"};
        foreach(string s in babbling){
            if(nextWord(s, babBase, "")) answer++;
        }
        return answer;
    }
    
    public bool nextWord(string s, string[] babBase, string canNot){
        if(s.Length==0) return true;
        foreach(string bab in babBase){
            if(bab==canNot) continue;
            if(s.Length<bab.Length) continue;
            if(s.Substring(0,bab.Length) == bab){
                return nextWord(s.Substring(bab.Length), babBase, bab);
            }
        }
        return false;
    }
}