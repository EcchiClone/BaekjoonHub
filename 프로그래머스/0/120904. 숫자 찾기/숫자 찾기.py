def solution(num, k):
    answer = 0
    sNum = str(num)
    for i in range(len(sNum)):
        if(sNum[i]==str(k)):
            answer = i+1
            break
    if(answer==0):
        answer = -1
    return answer