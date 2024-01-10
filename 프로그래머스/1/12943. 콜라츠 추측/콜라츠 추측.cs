public class Solution {
    public int solution(int num) {
        int answer = 0;
        
        long n = (long)num;
        int count = 0;
        
        while(n>1){
            
            if(count>=500){
                count = -1;
                break;
            }
            
            if(n%2==0){
                n/=2;
                count++;
                continue;
            }
            else{
                n = n*3 + 1;
                count++;
                continue;
            }
            
        }
        
        answer = count;
        
        return answer;
    }
}