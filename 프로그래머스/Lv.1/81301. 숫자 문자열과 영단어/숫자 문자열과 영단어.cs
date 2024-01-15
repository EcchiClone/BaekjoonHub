using System;

public class Solution {
    public int solution(string s) {
        int answer = 0;
        answer = int.Parse(s.Replace("zero", "0")
                            .Replace("one", "1")
                            .Replace("two", "2")
                            .Replace("three", "3")
                            .Replace("four", "4")
                            .Replace("five", "5")
                            .Replace("six", "6")
                            .Replace("seven", "7")
                            .Replace("eight", "8")
                            .Replace("nine", "9"));
        
        return answer;
    }
}