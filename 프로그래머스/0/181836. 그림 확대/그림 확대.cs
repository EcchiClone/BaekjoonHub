using System;
using System.Collections;
using System.Collections.Generic;

public class Solution {
    public string[] solution(string[] picture, int k) {
        List<string> answerList = new List<string>();
        
        foreach(var originLine in picture){
            for(int i = 0; i < k; i++){
                string line = "";
                foreach(char c in originLine){
                    for(int j = 0; j < k; j++){
                        line += c;
                    }
                }
                answerList.Add(line);
            }
        }
        
        string[] answer = answerList.ToArray();
        return answer;
    }
}