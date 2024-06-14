def solution(n):
    answer = []
    p = n
    answer.append(p)
    while(p!=1):
        if(p%2==0):
            p /= 2
        else:
            p = 3 * p + 1
        answer.append(p)
    return answer