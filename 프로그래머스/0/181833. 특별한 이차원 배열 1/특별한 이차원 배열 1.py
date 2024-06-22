def solution(n):
    answer = []
    d1 = []
    for _ in range(n):
        d1.append(0)
    for _ in range(n):
        answer.append(d1.copy())
    for i in range(n):
        answer[i][i] = 1
    return answer