using System;

class Solution
{
    public int solution(int n, int a, int b)
    {
        int answer = 0;

        // 솔루션 : 새로 배정받은 번호가 같을 때까지 반복, 같기 직전의 라운드가 만난 라운드.
        // 현재 번호에서 1을 더한 후, 2로 나누면 다음 번호인 것으로 보임.
        
        int aNow = a;
        int bNow = b;
        
        int round = 1;
        
        while (aNow!=bNow){
            
            round += 1;
            
            aNow = (aNow+1)/2;
            bNow = (bNow+1)/2;
            
        }
        
        answer = --round;
        
        return answer;
    }
}