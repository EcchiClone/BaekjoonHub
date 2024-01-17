using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int number, int limit, int power) {
        int answer = 0;
        
        // 각 수의 약수의 갯수 값을 갖는 배열 혹은 리스트를 마련
        // 각 요소마다, 기준 초과 시 {power} 값을 갖도록 수정
        // 총합 구하기
        List<int> citizen = new List<int>(Enumerable.Repeat(1, number+1));
        for(int i=2;i<=number;i++)
            for(int j=i;j<=number;j+=i)
                citizen[j]+=1;
        for(int i=1;i<=number;i++){
            if(citizen[i]>limit) citizen[i]=power;
            answer += citizen[i];
        }
        
        return answer;
    }
}