def solution(picture, k):
    answer = []
    
    for line in picture:
        for i in range(k):
            s = ""
            for c in line:
                for j in range(k): 
                    s+=c
            answer.append(s)
    
    return answer