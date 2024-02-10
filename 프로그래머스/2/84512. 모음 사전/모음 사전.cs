using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string word) {
        int answer = 0;
        // 입출력 예 에서("I":1563) 각각의 모음으로 시작하는 단어는 781 개 라는 것을 알았다.(확인용)
        // 즉 그냥 전체 단어 만들어서 정렬해도 4000개 이하 원소를 가지기 때문에 할만 함.
        // 다른 솔루션. 그냥 word의 첫 자리부터 각각 가중치를 주면 금방 끝날듯.
        // 첫자리              'A': 1,     'E': 782,   'I': 1563,  'O': 2344,  'U': 3125
        // 둘자리  'X': 0,     'A': 1,     'E': 157,   'I': 313,   'O': 469,   'U': 625
        // 셋자리  'X': 0,     'A': 1,     'E': 32,    'I': 63,    'O': 94,    'U': 125
        // 넷자리  'X': 0,     'A': 1,     'E': 7,     'I': 13,    'O': 19,    'U': 25
        // 닷자리  'X': 0,     'A': 1,     'E': 2,     'I': 3,     'O': 4,     'U': 5
        // 위 목록을 작성한 법 : 이후 자리의 끝 모음 +2을 현재자리의 B로.
        // 예를 들어 다섯자리의 U(5) 다음은 넷째자리의 E(6) 가 되며,
        // 넷째자리의 IOU도 규칙성에 따라 구하고
        // 넷째자리의 끝 U(21), 다섯째자리의 끝(5)를 더하여 1을 더하면 셋째자리의 E(27)이 된다.
        int[,] weights = new int[,]{
            {1,782,1563,2344,3125},
            {1,157,313,469,625},
            {1,32,63,94,125},
            {1,7,13,19,25},
            {1,2,3,4,5},
        };
        Dictionary<char, int> c = new Dictionary<char, int> {
            {'A', 0}, {'E', 1}, {'I', 2}, {'O', 3}, {'U', 4}
        };
        for(int depth = 0; depth<word.Length; depth++){
            answer += weights[depth,c[word[depth]]];
        }
        return answer;
    }
}