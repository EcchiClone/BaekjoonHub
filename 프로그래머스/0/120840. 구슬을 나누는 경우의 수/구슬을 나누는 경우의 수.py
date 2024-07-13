def solution(balls, share):
    answer = com(balls,share)
    return answer

def com(e,s):
    result = 1
    if e==0 or s==0:
        return 1
    for i in range(e,e-s,-1):
        result *= i
    for i in range(1,s+1):
        result /= i
    return int(result)