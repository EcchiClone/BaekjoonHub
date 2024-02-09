public class Solution {
    public long solution(int n) {
        long answer = 0;
        // 무슨 기법이었는지 이름은 까먹음
        // 점화식으로 풀이
        // answer(n) = answer(n-1)+answer(n-2);
        // answer(1) = 1;
        // answer(2) = 2;
        
        // Answer1을 사용한 방법은 시간초과.
        // answer = Answer1(n);
        
        // n이 최대 2000밖에 안 되니까, 그냥 Bottom에서 Top으로 하는 방법 사용하자.
        long n_2 = 1; // 초기값 answer(1);
        long n_1 = 2; // 초기값 answer(2);
        if(n==1) answer = n_2;
        else if(n==2) answer = n_1;
        else{
            for(int i=3; i<n; i++){
                long tmp = (n_2+n_1)%1234567;
                n_2 = n_1;
                n_1 = tmp;
            }
            answer = (n_2+n_1)%1234567;
        }
        
        return answer;
    }
    // public long Answer1(int n){
    //     if(n==1) return 1;
    //     if(n==2) return 2;
    //     return (Answer1(n-1)+Answer1(n-2))%1234567;
    // }
}