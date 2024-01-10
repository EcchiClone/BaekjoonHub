public class Solution {
    public int[] solution(long n) {
        
        long num = n;
        string numStr = num.ToString();
        
        int[] answer = new int[numStr.Length];
        
        int index = 0;
        
        while(num!=0){
            answer[index++] = (int)(num%10);
            num /= 10;
        }
        
        return answer;
    }
}