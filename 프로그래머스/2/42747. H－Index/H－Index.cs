using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] citations) {
        int answer = 0;
        
        // 솔루션 : 주어진 배열를 역순정렬, 첫 인덱스를 1로 두어 순회 시작
        // 인덱스 <= 인용수 를 만족하는 시점까지의 인덱스를 리턴.
        
        // 찾아보기 : Linq와 람다함수를 사용한 역순정렬
        citations = citations.OrderByDescending(c => c).ToArray();
        System.Console.WriteLine(citations[0]);
        for(int i=0;i<citations.Length;i++){
            if(i+1 <= citations[i]) answer = i+1;
            else                    break;
        }
        
        return answer;
    }
}