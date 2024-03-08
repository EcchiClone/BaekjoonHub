using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int k, int[] tangerine) {
        
        int answer = 0;
        
        // 솔루션. 
        // 1. 귤의 크기별로 개수를 세어두기
        // 2. k개의 귤을 선택할 때 가능한 한 서로 다른 크기의 종류를 최소화하기 위해, 가장 많이 있는 귤의 크기부터 선택
        
        // 귤의 크기별로 개수를 세어 저장
        Dictionary<int, int> countBySize = new Dictionary<int, int>();
        foreach (var size in tangerine) {
            if (!countBySize.ContainsKey(size)) {
                countBySize[size] = 0;
            }
            countBySize[size]++;
        }
        
        // 개수별로 내림차순 정렬
        var sortedCount = countBySize.ToList();
        sortedCount.Sort((pair1, pair2) => pair2.Value.CompareTo(pair1.Value));
        
        int remaining = k;
        int typeCount = 0;
        
        // 가장 많이 있는 귤의 크기부터 선택
        foreach (var pair in sortedCount) {
            if (remaining <= 0) break;
            remaining -= pair.Value;
            typeCount++;
        }
        
        answer = typeCount;
        
        return answer;
    }
}