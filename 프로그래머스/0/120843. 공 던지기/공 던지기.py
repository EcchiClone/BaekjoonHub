def solution(numbers, k):
    answer = 0
    lenp = len(numbers)
    idx = 0
    for _ in range(k-1):
        idx += 2
        if(idx>=lenp):
            idx -= lenp
    answer = idx + 1
        
    return answer