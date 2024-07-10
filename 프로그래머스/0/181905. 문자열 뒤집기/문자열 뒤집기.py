def solution(my_string, s, e):
    answer = ''
    if(s!=0):
        answer = my_string[:s] + my_string[e:s-1:-1] + my_string[e+1:]
    else:
        answer = my_string[e::-1] + my_string[e+1:]
    # print(answer)
    return answer