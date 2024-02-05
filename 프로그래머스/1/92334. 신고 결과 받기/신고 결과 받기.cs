using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string[] id_list, string[] report, int k) {
        int[] answer = new int[id_list.Length];
        
        // 솔루션
        // Dict1 : {"{ID}":{받을 메시지 수}}
        // Dict2 : {"{ID}":{List<string> ID를 신고한사람 목록}}
        // 1. Dict1과 Dict2를 초기화
        // 2. foreach문으로 report 순회하며 Dict2를 채운다
        // 3. Dict2를 순회하며 List의 길이가 k 이상일 경우,
        //    해당 리스트를 키로 갖는 Dict1의 값을 모두 1 더한다
        
        // 1. Dict1과 Dict2를 초기화
        // (Dictionary 안의 자료형으로 List<> 그냥 써 봤는데 왜 되는거야...)
        Dictionary<string, int> dict1 = new Dictionary<string, int>();
        Dictionary<string, List<string>> dict2 = new Dictionary<string, List<string>>();
        foreach(string id in id_list){
            dict1[id] = 0;
            dict2[id] = new List<string>(){};
            // Console.WriteLine(dict2[id].Count);
        }
        
        // 2. foreach문으로 report 순회하며 Dict2를 채운다
        foreach(string msg in report){
            string[] parts = msg.Split(' ');
            string userA = parts[0];
            string userB = parts[1];
            if(!dict2[userB].Contains(userA))
                dict2[userB].Add(userA);
        }
        
        // 3. Dict2를 순회하며 List의 길이가 k 이상일 경우,
        //    해당 리스트를 키로 갖는 Dict1의 값을 모두 1 더한다
        // 찾아보기: 사전형의 순회
        foreach(var item in dict2){
            if(item.Value.Count>=k){
                foreach(string user in item.Value){
                    dict1[user] += 1;
                }
            }
        }
        
        // 4. answer 배열에 dict1의 내용 옮기기
        for(int i=0;i<id_list.Length;i++){
            answer[i] = dict1[id_list[i]];
        }
        
        return answer;
    }
}