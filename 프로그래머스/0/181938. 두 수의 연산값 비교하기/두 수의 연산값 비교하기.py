def solution(a, b):
    answer = 0
    
    val1 = int(str(a)+str(b))
    val2 = 2 * a * b
    
    answer = max(val1,val2) ##
    
    return answer