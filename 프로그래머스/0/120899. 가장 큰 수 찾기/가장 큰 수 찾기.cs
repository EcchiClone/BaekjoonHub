using System;

public class Solution {
    public int[] solution(int[] array) {
        int[] answer = new int[] {-1, -1};
        for(int i=0;i<array.Length;i++){
            if(answer[0]<array[i]){
                answer[0] = array[i];
                answer[1] = i;
            }
        }
        return answer;
    }
}