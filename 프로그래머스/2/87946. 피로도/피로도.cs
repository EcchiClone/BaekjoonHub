// using System;
// using System.Linq;

// public class Solution {
//     public int solution(int k, int[,] dungeons) {
//         int answer = 0;
//         // 문제 이해 잘못하고 풀어서 지움, 다시 풀기
        
//         // 접근
//         // 80, [[80, 20], [50, 40], [30, 10]] 의 경우
//         // 아래의 바 의 위치를 조절하여 겹치지 사영했을 때 겹치지 않도록 최대한 많은 종류를 배치
//         // 0  10  20  30  40  50  60  70  80 (k값으로 최댓값을 초기화(80))
//         // |-------------------------------|
//         //                        [■■■■■■■■]
//         //    [■■■■■■■■■■■■■■■■------------]
//         //        [■■■■--------------------]
//         // 아래와 같이 바를 이동할 경우, 겹치지 않도록 세 종류의 던전을 돌 수 있다.
//         // 0  10  20  30  40  50  60  70  80
//         // |-------------------------------|
//         //                        [■■■■■■■■]
//         //    [■■■■■■■■■■■■■■■■------------]
//         //        [------------■■■■--------]
//         // 솔루션
//         // 내가 떠올릴 수 있는 최선이 이 방법뿐이라 슬프지만,
//         // 모든 k값에 대해 count하기.
//         // k(0)=0;
//         // for(i=1;i<=최대k;i++)
//         //
//         //      foreach (dungeon 전체)
//         //          if(i가 dungeon 시작점이라면, end가 최대k를 벗어나지 않는다면) : k(end) = k(i)+1
//         //
//         //      k(i) = max(k(i-1), k(i)) // 점화식
        
//         // 1. 필요한 값 초기화
//         int[] k_count = new int[k+1];
//         k_count[0]=0;
//         for(int i=1;i<=k;i++){
//             for(int j=0; j<dungeons.GetLength(0); j++){
//                 if(i==dungeons[j,0]-dungeons[j,1])
//             }
//         }
        
        
        
        
//         return answer;
//     }
// }

using System;

public class Solution { 
    public int solution(int k, int[,] dungeons) {
        int answer = 0;
        // 2024.04.22 완전탐색 사용
        int dungeonCount = dungeons.GetLength(0);
        int[] indices = new int[dungeonCount];
        for (int i = 0; i < dungeonCount; i++) {
            indices[i] = i;
        }
        
        int maxDungeons = 0;
        PermuteAndCalculate(ref maxDungeons, indices, k, dungeons, 0, dungeonCount);
        
        answer = maxDungeons;
        return maxDungeons;
    }
    
    private void PermuteAndCalculate(ref int maxDungeons, int[] indices, int k, int[,] dungeons, int start, int end) {
        if (start == end) {
            int currentFatigue = k;
            int count = 0;
            for (int i = 0; i < end; i++) {
                int minReq = dungeons[indices[i], 0];
                int cost = dungeons[indices[i], 1];
                if (currentFatigue >= minReq) {
                    currentFatigue -= cost;
                    count++;
                } else {
                    break;
                }
            }
            maxDungeons = Math.Max(maxDungeons, count);
        } else {
            for (int i = start; i < end; i++) {
                Swap(indices, start, i);
                PermuteAndCalculate(ref maxDungeons, indices, k, dungeons, start + 1, end);
                Swap(indices, start, i);
            }
        }
    }
    
    private void Swap(int[] array, int a, int b) {
        int temp = array[a];
        array[a] = array[b];
        array[b] = temp;
    }
}
