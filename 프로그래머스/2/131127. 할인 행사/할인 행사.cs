using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(string[] want, int[] number, string[] discount) {
        int answer = 0;
        
        // 솔루션
        // 1. Pivot1(0)과 Pivot2(sum(num)-1)를 마련하여
        // 2. discount 배열에서 두 피봇 내의 각각의 아이템이 몇개씩인지 조사, 갯수조건 맞으면 answer++
        // 3. 반복문
        // 3-1. Pivot1과 Pivot2를 1씩 더하기
        // 3-2. Pivot2가 discount의 길이 이상이 되면 break;
        // 3-3. 빠진 아이템의 갯수는 -1, 추가된 아이템의 갯수는 +1. 
        // 3-4. 갯수조건 맞으면 answer++; 
        
        // 0. 사전형 마련.
        Dictionary<string, int> dict_want = new Dictionary<string, int>();
        Dictionary<string, int> dict_now = new Dictionary<string, int>();
        for(int i = 0; i<want.Length; i++){
            dict_want[want[i]] = number[i]; 
            dict_now[want[i]] = 0; 
        }
        // 1. Pivot1(0)과 Pivot2(sum(num)-1)를 마련
        int pivot1 = 0;
        int pivot2 = number.Sum()-1;
        // 2. discount 배열에서 두 피봇 내의 각각의 아이템이 몇개씩인지 조사, 갯수조건 맞으면 answer++
        for(int i=pivot1;i<=pivot2;i++){
            if (dict_now.ContainsKey(discount[i])) dict_now[discount[i]]++;
        }
        bool isMatch = true;
        foreach(string str in want){
            if(dict_now[str]!=dict_want[str]){
                isMatch = false;
                break;
            }
        }
        if(isMatch) answer++;
        // 3. 반복문
        // 3-1. Pivot1과 Pivot2를 1씩 더하기
        // 3-2. Pivot2가 discount의 길이 이상이 되면 break;
        // 3-3. 빠진 아이템의 갯수는 -1, 추가된 아이템의 갯수는 +1. 
        // 3-4. 갯수조건 맞으면 answer++; 
        while(true){
            
            pivot1++; pivot2++;
            
            if(pivot2>= discount.Length) break;
            
            if (dict_now.ContainsKey(discount[pivot1-1])) dict_now[discount[pivot1-1]]--;
            if (dict_now.ContainsKey(discount[pivot2])) dict_now[discount[pivot2]]++;
            
            isMatch = true;
            foreach(string str in want){
                if(dict_now[str]!=dict_want[str]){
                    isMatch = false;
                    break;
                }
            }
            if(isMatch) answer++;
        }
        return answer;
    }
}