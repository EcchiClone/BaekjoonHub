def solution(arr, queries):
    answer = arr[:]
    for q in queries:
        answer[q[0]], answer[q[1]] = answer[q[1]], answer[q[0]]
    return answer