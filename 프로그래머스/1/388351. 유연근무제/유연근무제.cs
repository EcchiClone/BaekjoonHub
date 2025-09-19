using System;

public class Solution {
    public int solution(int[] schedules, int[,] timelogs, int startday) {
        int answer = 0;
        
        for(int person = 0; person < schedules.GetLength(0); person++){
            bool isClear = true;
            int aim = schedules[person] + 10;
            if(aim%100 > 59) aim += 40;
            
            for(int i = 0; i < timelogs.GetLength(1); i++){
                if ( timelogs[person,i] > aim && ((i+(startday-1))%7) < 5){
                    Console.WriteLine(timelogs[person,i]);
                    isClear = false;
                }
            }
            if(isClear) answer++;
        }
        
        return answer;
    }
}