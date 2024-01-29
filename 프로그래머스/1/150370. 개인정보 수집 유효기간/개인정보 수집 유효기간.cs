using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
        int[] answer = new int[] {};
        
        // 프로그래머스에서 메서드 사용하는 법 및 출력메시지 띄우는 법 확인
        // hello();
        
        // 예상 솔루션
        // 1. terms는 사전형 변수에 저장
        // 2. 년도에는 365, 달에는 28, 일에는 1의 가중치를 두어 각 정보와 today를 비교
        // 3. privacy가 같거나 작을 경우, result에 추가
        // 3-1. result는 값 갯수의 변동이 있으므로 리스트로 관리
        List<int> result = new List<int>();
        
        // 1. terms를 사전형 변수에 저장
        Dictionary<char,int> termsDict = new Dictionary<char,int>();
        foreach(string term in terms){
            // 검색: split 사용법(파이썬의 term.split())
            // -> 마찬가지로 term.Split(' '); 과 같이 사용 가능
            // 검색: 특정 인덱스 이후 모든 문자열을 사용하는법(파이썬의 term[2:])
            // -> term.Substring(2); 과 같이 사용 가능
            char key = term[0];
            int value = int.Parse(term.Substring(2));
            
            // Console.WriteLine($"{key}: {value}"); // 테스트 구문
            
            // 검색: 사전형에 요소 추가
            // -> termsDict.Add(key, value);
            
            termsDict.Add(key, value);
        }
        
        // 2. 년은 365, 달은 28, 일은 1의 가중치를 두어 각 정보와 today를 비교
        int today_value = 0;
        today_value = 
            int.Parse(today.Substring(0,4)) * 28*12 +
            int.Parse(today.Substring(5,2)) * 28 +
            int.Parse(today.Substring(8,2)) * 1
            ;
        Console.WriteLine($"Today value: {today_value}"); // 테스트 구문
        for(int i=0; i<privacies.Length; i++){
            string privacy = privacies[i];
            int limitDay_value = 
                int.Parse(privacy.Substring(0,4)) * 28*12 +
                int.Parse(privacy.Substring(5,2)) * 28 +
                int.Parse(privacy.Substring(8,2)) * 1 +
                termsDict[privacy[11]] * 28
                ;
            Console.WriteLine($"privacy index[{i+1}] value: {limitDay_value}"); // 테스트 구문
            // 3. privacy가 작을 경우, result에 추가
            if(limitDay_value <= today_value)
                result.Add(i+1);
        }
        
        answer = result.ToArray();
        
        return answer;
    }
    
    public void hello(){
        Console.WriteLine("Hello");
    }
}