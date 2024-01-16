using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        
        // O(N^2)도 되겠지만, 더 효율적인 알고리즘으로...
        // s가 영어 소문자로만 이루어져 있다고 하니, 26개 소문자의 index 리스트를 작성하자
        Dictionary<char, int> alphaIndex = new Dictionary<char, int>();
        
        // a부터 z까지 -1 설정
        for (char c = 'a'; c <= 'z'; c++) {
            alphaIndex.Add(c, -1);
        }
        
        // s를 처음부터 순회하며 answer와 alphaIndex 갱신
        for (int i = 0; i<s.Length; i++){
            if(alphaIndex[s[i]]==-1) answer[i] = -1;
            else answer[i] = i-alphaIndex[s[i]];
            
            alphaIndex[s[i]] = i;
        }
        
        return answer;
    }
}