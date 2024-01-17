using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        
        char x = ' ';
        int counter = 0;
        foreach(char c in s){
            if(counter==0){
                answer++;
                x = c;
            }
            if(x==c) counter++;
            else counter--;
        }
        return answer;
    }
}