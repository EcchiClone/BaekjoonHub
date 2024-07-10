def solution(s):
    answer = 0
    sp = s.split()
    for i in range(len(sp)):
        if(sp[i]=='Z'):
            answer -= int(sp[i-1])
        else:
            answer += int(sp[i])
    return answer