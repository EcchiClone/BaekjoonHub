def solution(s):
    answer = ''
    already = ''
    outc = ''
    answerL = []
    for c in s:
        if c in already:
            if(c not in outc):
                outc += c
        else:
            already += c
    for c in s:
        if c not in outc:
            answerL.append(c)
    answerL.sort()
    print(answerL)
    answer = ''.join(answerL)
    return answer