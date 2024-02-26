using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string[,] clothes) {
        int answer = 1;
        // 의상 카테고리의 dict 마련
        Dictionary<string,int> dict = new Dictionary<string,int>();
        
        for (int i = 0; i < clothes.GetLength(0); i++) {
            if(dict.ContainsKey(clothes[i, 1]))
                dict[clothes[i, 1]]++; 
            else
                dict[clothes[i, 1]] = 2; 
        }
        foreach(var item in dict){
            answer *= item.Value;
        }
        answer--;
        return answer;
    }
}