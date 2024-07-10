def solution(arr):
    answer = []
    for item in arr:
        if answer == []:
            answer.append(item)
        elif answer[-1]==item:
            answer = answer[:-1]
        else:
            answer.append(item)
    if(answer==[]):
        answer = [-1]
    return answer