def solution(arr):
    answer = []
    minIdx = -1
    maxIdx = 100000
    for i in range(len(arr)):
        if arr[i]==2:
            minIdx = i
            break
    for i in range(len(arr)-1, -1, -1):
        if arr[i]==2:
            maxIdx = i
            break
    if minIdx == -1:
        answer = [-1]
    else:
        answer = arr[minIdx:maxIdx+1]
    return answer