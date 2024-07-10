def solution(n):
    answer = []
    nowi = 2
    nown = n
    while(nown!=1):
        if(nown%nowi==0):
            nown/=nowi
            if(nowi not in answer):
                answer.append(nowi)
            continue
        else:
            nowi += 1
        
        
    return answer