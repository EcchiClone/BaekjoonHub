using System;
using System.Linq;

public class Solution {
    public int[] solution(string _s) {
        int[] answer = new int[2];
        string s = _s;
        
        int count = 0;
        int deletedZero = 0;
        
        while(s!="1"){
            
            deletedZero += s.Count(c => c == '0');
            s = nToBin(s.Count(c => c == '1'));
            
            count += 1;
        }
        
        answer[0] = count;
        answer[1] = deletedZero;
        
        return answer;
    }
    public string nToBin(int _n){
        int n = _n;
        string result = "";
        while(n>0){
            result = (n%2).ToString() + result;
            n /=2;
        }
        return result;
    }
}