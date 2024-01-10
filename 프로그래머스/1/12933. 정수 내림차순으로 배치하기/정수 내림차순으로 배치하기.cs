using System.Collections.Generic;

public class Solution {
    public long solution(long n) {
        long answer = 0;
        
        long num = n;
        
        List<int> list = new List<int>();
        
        while(num!=0){
            list.Add((int)(num%10));
            num /= 10;
        }
        
        list.Sort();
        list.Reverse();
        
        string outStr = "";
        
        foreach (int item in list){
            outStr += item.ToString();
        }
        
        answer = long.Parse(outStr);
        
        
        
        return answer;
    }
}