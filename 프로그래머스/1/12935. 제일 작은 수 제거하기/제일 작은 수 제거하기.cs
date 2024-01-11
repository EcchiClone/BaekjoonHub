using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
        
        int[] answer = new int[] {};
        
        if(arr.Length<=1) return new int[] { -1, };
        
        int minIdx = 0;
        
        for(int i=1; i<arr.Length; i++){
            if(arr[i]<arr[minIdx]) minIdx = i;    
        }
        
        answer = arr.Where((val, index) => index != minIdx).ToArray();
        
        return answer;
        
        
        
    }
}