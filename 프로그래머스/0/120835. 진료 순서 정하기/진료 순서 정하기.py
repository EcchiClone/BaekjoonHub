def solution(emergency):
    answer = [1 for _ in range(len(emergency))]
    for i in range(len(emergency)):
        for j in emergency:
            if j > emergency[i]:
                answer[i] += 1
    
    return answer