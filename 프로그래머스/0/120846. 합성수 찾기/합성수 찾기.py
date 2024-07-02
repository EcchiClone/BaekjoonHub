def solution(n):
    answer = 0
    li = [i for i in range(2,n+1)]
    idx = 0
    while(idx < len(li)):
        for i in range(len(li)-1, idx, -1):
            if li[i]%li[idx]==0:
                li.pop(i)
        idx += 1
    answer = n - len(li) - 1
                
    
    return answer