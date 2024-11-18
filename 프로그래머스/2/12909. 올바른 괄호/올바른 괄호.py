def solution(s):
    answer = True
    
    counter = 0
    
    for c in s:
        if c=='(':
            counter += 1
        else:
            counter -= 1
        if counter < 0:
            return False
    if counter != 0:
        return False
    
    
    return True