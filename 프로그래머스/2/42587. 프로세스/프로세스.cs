using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int solution(int[] priorities, int location) {
        int answer = 0;
        
        // 솔루션
        // 1. 프로세스와 해당 우선순위를 KeyValuePair<int, int>로 큐에 저장
        // 2. 큐가 비지 않은 경우 큐에서 하나씩 아이템을 꺼내
        //    현재 꺼낸 아이템의 우선순위보다 높은 우선순위를 가진 아이템이 있는지 확인
        // 3-1. 더 높은 우선순위를 가진 프로세스가 있다면, 현재 꺼낸 프로세스를 큐의 끝에 다시 추가
        // 3-2. 더 높은 우선순위를 가진 프로세스가 없다면, 현재 꺼낸 프로세스를 실행하고 answer를 1 증가
        // 4. 꺼낸 프로세스의 위치(Value)가 주어진 location과 일치하는지 확인
        //    일치 시, 현재까지 실행한 프로세스의 수인 answer를 반환
        
        Queue<KeyValuePair<int, int>> queue = new Queue<KeyValuePair<int, int>>();
        
        for (int i = 0; i < priorities.Length; i++) {
            queue.Enqueue(new KeyValuePair<int, int>(priorities[i], i));
        }
        
        while (queue.Count > 0) {
            var item = queue.Dequeue();
            if (queue.Any(x => x.Key > item.Key)) {
                queue.Enqueue(item);
            } else {
                answer++;
                if (item.Value == location) {
                    return answer;
                }
            }
        }
        
        return answer;
    }
}