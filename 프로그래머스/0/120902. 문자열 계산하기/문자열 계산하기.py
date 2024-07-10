def solution(my_string):
    answer = 0
    sp = my_string.split()
    answer = int(sp[0])
    for i in range(2, len(sp), 2):
        if(sp[i-1]=='-'):
            answer -= int(sp[i])
        if(sp[i-1]=='+'):
            answer += int(sp[i])
    return answer