using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int n, int m, int[] section) {
        int answer = 0;
        
        List<int> sectionList = section.ToList();
        
        while(sectionList.Count!=0){
            int maxPaint = sectionList[0]+m-1;
            while(true){
                if(sectionList.Count==0) break;
                else if(sectionList[0]<=maxPaint) sectionList.RemoveAt(0);
                else break;
            }
            answer++;
        }
        
        return answer;
    }
}