using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int[] answer = new int[2];
        // 허... 수학문제다
        // 컴퓨터식으로 해결하자.. ㅠ
        // 갈색에서 넷을 빼고, 4를 나눌 경우 최대 넓이.
        int maxAreaD1 = (brown-4)%4==0 ? (brown-4)/4 : (brown-4)/4+1;
        int maxAreaD2 = (brown-4)/4; // D1 >= D2 이다.
        // brown은 8 이상 5000 이하이므로, 각각의 범위는
        // 1 <= maxAreaD2 <= maxAreaD1 <= 1249
        // D1을 1씩 늘려나가는 동시에 D2를 1씩 줄여나가며 만족하는 노랑 면적이 나오는지 확인 해 주자.
        // 노랑은 1 이상을 보장받았음에도 유의. 각 변은 반드시 3 이상의 크기를 갖는다.
        // maxAreaD1와 maxAreaD2는, 네 모퉁이를 뺀 값이므로, 둘을 곱할 경우 노랑의 면적이 나옴.
        while (maxAreaD2>=1){
            if(maxAreaD1 * maxAreaD2 == yellow)
                break;
            maxAreaD1++;
            maxAreaD2--;
        }
        
        answer[0] = maxAreaD1+2;
        answer[1] = maxAreaD2+2;
        
        return answer;
    }
}