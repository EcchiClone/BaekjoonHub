using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        int answer = n;
        
        List<int> lostList = lost.ToList();
        List<int> reserveList = reserve.ToList();
        
        lostList.Sort();
        reserveList.Sort();
        
        for (int i = lostList.Count - 1; i >= 0; i--) {
            if (reserveList.Contains(lostList[i])) {
                reserveList.Remove(lostList[i]);
                lostList.RemoveAt(i);
            }
        }
        
        foreach(int lostNum in lostList){
            if(reserveList.Contains(lostNum-1))
                reserveList.Remove(lostNum-1);
            else if(reserveList.Contains(lostNum+1))
                reserveList.Remove(lostNum+1);
            else
                answer--;
        }
        return answer;
    }
}