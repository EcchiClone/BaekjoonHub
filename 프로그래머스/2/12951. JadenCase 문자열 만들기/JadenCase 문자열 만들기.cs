using System;
using System.Linq;
public class Solution {
    public string solution(string s) {
        string answer = "";
        
        // 찾아보기 : Uppercase, Lowercase 메서드가 있는지
        // string 과 char 에서 ToUpper(), ToLower() 사용 가능
        // myString.ToUpper();
        // Char.ToUpper(lowerChar);
        
        // List<string> list_split = s.Split(' ')
        //     .Select(word => word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower())
        //     .ToList();
        
        // 한줄쓰기
        // answer = string.Join(" ", s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
        //                      .Select(word => word.Length > 0 
        //                                      ? word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower() 
        //                                      : word));
        
        // 정공법
        // 1. 순회하며 앞문자가 ' '라면 ToUpper(), 아니라면 Tolower()
        answer = s[0].ToString().ToUpper();
        for(int i=1;i<s.Length;i++){
            if(s[i-1]==' ') answer += s[i].ToString().ToUpper();
            else answer += s[i].ToString().ToLower();
        }

        
        return answer;
    }
}