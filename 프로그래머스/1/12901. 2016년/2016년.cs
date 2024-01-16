public class Solution {
    public string solution(int a, int b) {
        string answer = "";
        
        int[] month = { 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        string[] week = { "THU", "FRI", "SAT", "SUN", "MON", "TUE", "WED" };
        int total = 0;

        for (int i = 0; i < a - 1; i++) {
            total += month[i];
        }

        total += b;

        answer = week[total % 7];
        
        return answer;
        
    }
}