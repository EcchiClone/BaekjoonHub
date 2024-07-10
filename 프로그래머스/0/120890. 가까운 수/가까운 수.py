def solution(array, n):
    answer = 0
    minus = min([-(i-n) for i in array if i<n] + [100])
    plus = min([i-n for i in array if i>=n] + [100])
    if minus <= plus:
        answer = n - minus
    else :
        answer = n + plus
        
    return answer