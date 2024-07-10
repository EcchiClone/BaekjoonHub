def solution(myString):
    answer = sorted([s for s in (myString.split('x')) if s != ''])    
    return answer