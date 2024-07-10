def solution(arr, queries):
    answer = arr[:]
    for q in queries:
        for qi in range(q[0],q[1]+1):
            answer[qi] += 1
    return answer