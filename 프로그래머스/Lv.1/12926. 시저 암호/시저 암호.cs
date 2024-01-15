public class Solution {
    public string solution(string s, int n) {
        string answer = "";
        
        foreach(char c in s){
            char output;
            if (c == ' ') output = c;
            else if(c<=90) output = (char)(c + ((c+n<=90)?n:(n-26)) ) ; // 소문자
            else output = (char)(c + ((c+n<=122)?n:(n-26)) ); // 대문자
            answer += output.ToString();
        }
        
        return answer;
    }
}