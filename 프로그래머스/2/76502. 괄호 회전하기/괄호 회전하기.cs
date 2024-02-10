using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string s) {
        
        // 솔루션 : s + s.Substring(0,s.Length-1) 의 문자열을 두어, s.Length 길이만큼 체크 순회
        // 스택 시스템 이용
        
        int answer = 0;
        
        string sLarge = s + s.Substring(0, s.Length-1);
        
        for(int start=0; start<s.Length; start++){ // 스타트 지점의 설정
            // 입력이 홀수개인 경우, answer=0 으로 return
            if(s.Length%2==1) return 0;
            // 찾아보기 : 스택 사용법
            Stack<char> stack = new Stack<char>();
            bool goodNow=true;
            for(int i=0; i<s.Length&&goodNow; i++){
                switch(sLarge[start+i]){
                    case '(':
                        stack.Push('(');
                        break;
                    case '[':
                        stack.Push('[');
                        break;
                    case '{':
                        stack.Push('{');
                        break;
                    case ')':
                        goodNow = checkPop(stack, '(');
                        break;
                    case ']':
                        goodNow = checkPop(stack, '[');
                        break;
                    case '}':
                        goodNow = checkPop(stack, '{');
                        break;
                }
            }
            if(goodNow) answer++;
        }
        return answer;
    }
    public bool checkPop(Stack<char> stack, char c){
        bool goodNow = true;
        if(stack.Count != 0){
            char pop = stack.Pop();
            if(pop!=c) goodNow=false;
        }
        else goodNow=false;
        return goodNow;
    }
}