def solution(arr):
    for i in range(len(arr)):
        for j in range(i):
            if(arr[i][j]!=arr[j][i]):
                return 0
    return 1