using System;

public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        
        // 행렬곱 솔루션
        int arr1Rows = arr1.GetLength(0);
        int arr1Cols = arr1.GetLength(1);
        int arr2Rows = arr2.GetLength(0);
        int arr2Cols = arr2.GetLength(1);

        int[,] answer = new int[arr1Rows, arr2Cols];

        for (int i = 0; i < arr1Rows; i++) {
            for (int j = 0; j < arr2Cols; j++) {
                answer[i, j] = 0;
                for (int k = 0; k < arr1Cols; k++) {
                    answer[i, j] += arr1[i, k] * arr2[k, j];
                }
            }
        }

        return answer;
    }
}
