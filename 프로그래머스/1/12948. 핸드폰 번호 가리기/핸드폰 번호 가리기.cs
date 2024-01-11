public class Solution {
    public string solution(string phone_number) {
        string answer = "";
        
        for(int i=0; i<phone_number.Length; i++){
            answer += (i<phone_number.Length-4?"*":phone_number[i].ToString());
        }
        
        return answer;
    }
}