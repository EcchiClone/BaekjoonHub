using System.Collections.Generic;
using System.Linq;
using System;

public class Solution {
    public string solution(string s) {
        string answer = "";
        
        // 정수로 변환 불가능한 요소가 있다면, 예외처리를 해야하지만 조건이 보증하기 때문에 사용하지 않음.
        List<int> list_s = s.Split(' ').Select(int.Parse).ToList();
        
        int min = list_s.Min();
        int max = list_s.Max();

        answer = $"{min} {max}";
        
        return answer;
    }
}