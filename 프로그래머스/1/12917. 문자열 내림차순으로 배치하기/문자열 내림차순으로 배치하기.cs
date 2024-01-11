using System.Collections.Generic;

public class Solution {
    public string solution(string s) {
        string answer = "";
        
        List<char> lower = new List<char>();
        List<char> upper = new List<char>();
        
        foreach(char c in s){
            if('a'<=c && c<='z') lower.Add(c);
            else upper.Add(c);
        }
        lower.Sort();
        lower.Reverse();
        upper.Sort();
        upper.Reverse();
        
        string lowerStr = string.Join("", lower);
        string upperStr = string.Join("", upper);
        
        answer = lowerStr+upperStr;
        
        // 아스키 순서가 아닌 줄 착각하여 lower upper 구분했는데, 그럴 필요 없었던 듯
        
        return answer;
    }
}