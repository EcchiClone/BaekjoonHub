public class Solution {
    public bool solution(string s) {
        bool answer = false;
        
        if((s.Length==4 || s.Length==6) && int.TryParse(s, out _)) answer = true;
        
        return answer;
    }
}