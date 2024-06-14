def solution(myString):
    answer = [0]
    for c in myString:
        if c=='x':
            answer.append(0)
        else:
            answer[-1] += 1
    
    return answer