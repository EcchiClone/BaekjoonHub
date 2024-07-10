def solution(i, j, k):
    answer = 0
    for n in range(i,j+1):
        for c in str(n):
            if int(c) == k:
                answer += 1
    return answer