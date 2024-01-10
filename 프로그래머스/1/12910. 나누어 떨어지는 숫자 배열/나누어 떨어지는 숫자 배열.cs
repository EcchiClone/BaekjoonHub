using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int[] answer;
        
        List<int> answerList = new List<int>();
        
        foreach(int item in arr){
            if(item % divisor == 0){
                answerList.Add(item);
            }
        }
        
        answerList.Sort();
        
        if(answerList.Count==0) answer = new int[] {-1,};
        else answer = answerList.ToArray();
        
        return answer;
    }
}