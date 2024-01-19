using System;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] ingredient) {
        int answer = 0;
        
        List<int> stackAll = new List<int>();
        List<int> stackIdx = new List<int>();
        int idx = -1;
        foreach(int item in ingredient){
            
            // 버거 만드는 조건
            if(item==1 && stackIdx.Count!=0 && stackIdx[stackIdx.Count-1]!=idx &&
               (stackAll[stackAll.Count-1]==3&&stackAll[stackAll.Count-2]==2&&stackAll[stackAll.Count-3]==1)){
                int removeCount = idx - stackIdx[stackIdx.Count-1]+1;
                stackAll.RemoveRange(stackIdx[stackIdx.Count-1], removeCount);
                idx -= removeCount;
                stackIdx.RemoveAt(stackIdx.Count-1);
                answer++;
            }
            
            // 버거 쌓음
            else{
                idx++;
                stackAll.Add(item);
                if(item==1)
                    stackIdx.Add(idx);
            }
            // Console.WriteLine(idx);
        }
        return answer;
    }
}