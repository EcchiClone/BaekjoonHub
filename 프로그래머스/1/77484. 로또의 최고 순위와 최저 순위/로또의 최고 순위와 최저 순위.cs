using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int[] answer = new int[] {7,7};
        
        int zeros = 0;
        foreach(int item in lottos){
            if(item==0) zeros++;
            foreach(int winN in win_nums)
                if(item==winN) answer[1]--;
        }
        answer[0] = answer[1] - zeros;
        if(answer[0]==7) answer[0]=6;
        if(answer[1]==7) answer[1]=6;
        return answer;
    }
}