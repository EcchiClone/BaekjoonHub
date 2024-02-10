using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] elements) {
        int answer = 0;
        
        // 솔루션 : elements.Lenght*2-1의 배열, 합을 키로 갖는 dict 마련하여 순회
        int[] eLarge = new int[elements.Length*2-1];
        for(int i=0;i<elements.Length*2-1;i++)
            eLarge[i] = elements[i%elements.Length];
        Dictionary<int, bool> sum = new Dictionary<int, bool>();
        for(int s=0; s<elements.Length; s++)
            for(int i=0; i<elements.Length;i++)
                // 찾아보기 : Linq를 사용한, 배열의 특정 구간 합
                sum[eLarge.Skip(s).Take((s+i) - s + 1).Sum()] = true;
        answer = sum.Count();
        // 와; 바로 되니까 무서울정도..
        return answer;
    }
}