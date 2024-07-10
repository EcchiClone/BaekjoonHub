def solution(arr):
    answer = arr[:]
    targetlen = 1
    lenarr = len(arr)
    while(targetlen < lenarr):
        targetlen *= 2
    for _ in range(targetlen - lenarr):
        answer.append(0)
    return answer