using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string solution(string[] survey, int[] choices) {
        string answer = "";
        
        // 일주일 쉬어서 감 다 죽음
        
        // 찾아보기-1. choices의 각 원소를 3 빼서 새로운 배열에 담는 법(Linq)
        // int[] newChoices = choices.Select(choice => choice - 4).ToArray();
            // choices.Select(choice => choice - 4)를 사용했을 때의 결과 자료형은 IEnumerable<int>
            // LINQ의 Select 메서드는 컬렉션의 각 요소에 대해 지정된 변환 함수를 적용하고
            // 변환된 요소들을 포함하는 새로운 IEnumerable<T> 시퀀스를 반환
            // 변환 함수 choice => choice - 4는 정수를 반환하기 때문에, 결과 시퀀스의 타입은 IEnumerable<int>
        
        // 생각해보니, 위 방식은 설문결과의 분산(?)을 알 수 없게 만드는 요인이 되기 떄문에 사용하지 않도록 했다.
        
        // 찾아보기-2. 사전형식 자료형 초기화
        Dictionary<char, int> scores = new Dictionary<char, int>{
            {'R',0},{'T',0},{'C',0},{'F',0},
            {'J',0},{'M',0},{'A',0},{'N',0},
        };
            // var 사용과 Dictionary<char, int> 사용 중 자유롭게 선택. 장단점은 특별한 건 없고 상황이나 취향에 맞게.
        
        // 각 문항별 점수 집계
        int threshold = 4;
        for(int i = 0; i < choices.Length; i++){
            int selectedNum = choices[i];
            if(selectedNum<threshold)
                scores[survey[i][0]] += (threshold - selectedNum);
            if(selectedNum>threshold)
                scores[survey[i][1]] += (selectedNum - threshold);
        }
        
        // 성격유형 진단
        if(scores['R']>=scores['T'])    answer += 'R'.ToString();
        else                            answer += 'T'.ToString();
        if(scores['C']>=scores['F'])    answer += 'C'.ToString();
        else                            answer += 'F'.ToString();
        if(scores['J']>=scores['M'])    answer += 'J'.ToString();
        else                            answer += 'M'.ToString();
        if(scores['A']>=scores['N'])    answer += 'A'.ToString();
        else                            answer += 'N'.ToString();
        
        return answer;
    }
}