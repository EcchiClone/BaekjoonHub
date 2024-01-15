using System;
public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];

        for (int i = 0; i < commands.GetLength(0); i++) {
            int start = commands[i, 0] - 1;
            int end = commands[i, 1];
            int length = end - start;
            int[] instantArray = new int[length];
            
            Array.Copy(array, start, instantArray, 0, length);
            Array.Sort(instantArray);

            int kthIndex = commands[i, 2] - 1;
            answer[i] = instantArray[kthIndex];
        }

        return answer;
        }
}