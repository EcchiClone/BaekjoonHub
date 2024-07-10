def solution(n):
    answer = 0
    nowT = 1
    for i in range(2,13):
        print(nowT)
        if nowT > n:
            return i-2
        else:
            nowT *= i
    
    return answer