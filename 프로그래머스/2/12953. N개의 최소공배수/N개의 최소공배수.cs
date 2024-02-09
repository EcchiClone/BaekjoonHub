public class Solution {
    public int solution(int[] arr) {
        int answer = 0;
        
        // 솔루션 : 두 수 A, B간 최소공배수를 만드는 로직을 작성한 후, 주어진 모든 수를 순회.
        // 최소공배수 = A * B / (A와 B의 최대공약수)
        // 찾아보기 : 최대공약수 및 최소공배수 약자
        // 최대공약수 : Greatest common divisor, GCM, G
        // 최소공배수 : least common multiple, LCM, L
        // 각각 메서드로 작성
        
        int nowLcm = 1;
        
        foreach(int ele in arr){
            nowLcm = LCM(nowLcm, ele);
        }
        
        answer = nowLcm;
        
        return answer;
    }
    public int GCM(int _a, int _b){
        // 두 수를 서로 계속 나머지만 남기면서, 서로 배수 관계가 될 때까지 진행
        // 찾아보기 : 몫과 나머지 영어로
        // 몫 : quotient
        // 나머지 : remainder
        int a = _a>_b ? _a : _b; // a 가 b 이상이 되도록
        int b = _a>_b ? _b : _a; 
        while(a%b!=0){
            int tmp = a%b;
            a = b;
            b = tmp;
        }
        return b;
    }
    public int LCM(int _a, int _b){
        return _a * _b / GCM(_a,_b);
    }
}