using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    
    int n;
    int m;
    
    int[,] q;
    int[] ans;
    
    int result = 0;
    
    public int solution(int n, int[,] q, int[] ans) {
        
        this.n = n;
        this.m = q.GetLength(0);
        this.q = q;
        this.ans = ans;
        // 어떻게 할 건지?
        // 전 범위 탐색
        // 30C5 = 30*29*28*27*26/5/4/3/2 = 29*7*27*26 210000
        
        // n 중 5개 모든 조합을 어떻게 만들건지? for문?
        
        int[] comb = new int[5];
        DFS(1,0,comb); // start, depth, ...
        
        return result;
    }
    
    private void DFS(int start, int depth, int[] comb){
        if(depth == 5){
            if(IsValid(comb)) result++;
            return;
        }
        for(int i=start; i<=n; i++){
            comb[depth]=i;
            DFS(i+1,depth+1,comb);
        }
    }
    
    private bool IsValid(int[] comb){
        HashSet<int> code = new HashSet<int>(comb);
        for (int i=0;i<m;i++){
            int match=0;
            for(int j=0;j<5;j++){
                if(code.Contains(q[i,j])) match++;
            }
            if(match!=ans[i])
                return false;
        }
        return true;
    }
}