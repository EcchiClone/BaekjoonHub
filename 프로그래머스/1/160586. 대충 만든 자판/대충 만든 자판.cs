using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] keymap, string[] targets) {
        int[] answer = new int[targets.Length];
        // 매핑에 사용되는 시간 : 100*100*26 = 최대 26만
        Dictionary<char,int> minDict = new Dictionary<char,int>();
        for (int i = 0; i < 26; i++)
        {
            char ch = (char)('A' + i);
            minDict[ch] = 100;
        }
        for(int i=0;i<26;i++){
            int min = minDict[(char)('A' + i)];
            for (int j=0;j<keymap.Length;j++){
                for (int k=0;k<Math.Min(keymap[j].Length,min);k++)
                    if (keymap[j][k]==(char)('A' + i)) min = k;
                
            }
            min++;
            if(min>100) min=-1;
            minDict[(char)('A' + i)] = min;
        }
        for (int i = 0; i < 26; i++)
        {
            char ch = (char)('A' + i);
            Console.Write(minDict[ch]+" ");
        }
        
        // 탐색에 사용되는 시간 100*100 = 최대 10000
        for(int i=0;i<targets.Length;i++)
            for(int j=0;j<targets[i].Length;j++){
                if(minDict[targets[i][j]]==-1){
                    answer[i] = -1;
                    break;
                }
                answer[i] += minDict[targets[i][j]];
            }
        
        return answer;
    }
}