using System;

class Solution
{
    public long solution(int price, int money, int count)
    {
        long answer = 0;
        
        long sum = 0;
        int mul = count * (count+1) / 2;
        long need = (long)price * (long)mul;
        answer = Math.Max(0,need-money);
        
        return answer;
    }
}