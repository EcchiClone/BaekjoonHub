def solution(array):
    answer = 0
    for n in array:
        for c in str(n):
            if c=='7':
                answer += 1
    return answer