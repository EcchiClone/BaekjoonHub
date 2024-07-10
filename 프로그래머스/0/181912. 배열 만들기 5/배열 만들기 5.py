def solution(intStrs, k, s, l):
    answer = []
    answer = [int(n[s:s+l]) for n in intStrs if int(n[s:s+l])>k]
    
    return answer