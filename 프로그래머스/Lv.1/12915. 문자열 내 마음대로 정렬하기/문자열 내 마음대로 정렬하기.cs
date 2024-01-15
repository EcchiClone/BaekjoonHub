using System;
public class Solution {
    public string[] solution(string[] strings, int n) {
        string[] answer = strings;
        
        // 하... 문제 빡세다 빡세 '-`
        // 파이썬에서 동일한 문제 유형, index로 n번째 글자 넣어서 정렬 하는 방법 있었는데 까먹음..
        for(int i=0;i<answer.Length-1;i++){
            for(int j=i+1;j<answer.Length;j++){
                if(answer[i][n]>answer[j][n]){
                    string tmp = answer[i];
                    answer[i] = answer[j];
                    answer[j] = tmp;
                }
                else if(answer[i][n]==answer[j][n]){
                    for (int k=0; k < Math.Min(answer[i].Length, answer[j].Length); k++){
                        if(answer[i][k]>answer[j][k]){
                            string tmp = answer[i];
                            answer[i] = answer[j];
                            answer[j] = tmp;
                            break;
                        }
                        else if(answer[i][k]<answer[j][k]){
                            break;
                        }
                    }
                }
            }
        }
        return answer;
    }
}