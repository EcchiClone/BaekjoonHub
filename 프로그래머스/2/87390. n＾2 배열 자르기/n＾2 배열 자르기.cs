using System;

public class Solution {
    public int[] solution(int n, long left, long right) {
        int[] answer = new int[right - left + 1];
        // 0 1 2
        // 1 1 2
        // 2 2 2 ... 와 같이 생각하고, 출력만 +1 하자.
        // left는 위에서 (left / n) 의 인덱스, 왼쪽에서 (left % n) 번 인덱스
        // 현재 위치의 숫자는, max(위로부터 인덱스, 왼쪽으로부터의 인덱스)
        long n_long = n;
        for(long i=left; i<=right; i++){
            long value = ((i/n_long) > i%n_long) ? i/n_long+1 : i%n_long+1;
            answer[i-left] = (int)value;
        }
        
        return answer;
    }
}