using System;
using System.Collections.Generic;

public class Solution {
    public string solution(string s, string skip, int index) {
        string answer = "";
        
        // skip 목록을 제외한, 사용이 가능한 문자 리스트
        List<char> usableChar = new List<char>();
        for(int i = (int)'a'; i<=(int)'z'; i++){
            if(!skip.Contains((char)i))
                usableChar.Add((char)i);
        }
        // 문자열 s 변환
        for(int i=0;i<s.Length;i++){
            int usableIdx = usableChar.IndexOf(s[i]);
            usableIdx = (usableIdx+index)%usableChar.Count;
            answer += usableChar[usableIdx].ToString();
        }
        
        return answer;
    }
}