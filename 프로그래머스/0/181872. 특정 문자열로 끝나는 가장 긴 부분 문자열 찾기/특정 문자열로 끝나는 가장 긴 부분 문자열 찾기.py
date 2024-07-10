def solution(myString, pat):
    answer = ''
    for i in range(len(myString)-len(pat),-1,-1):
        # print(f'{myString[i:i+len(pat)]}, {pat}')
        if(myString[i:i+len(pat)] == pat):
            answer = myString[:i+len(pat)]
            break
    
    return answer