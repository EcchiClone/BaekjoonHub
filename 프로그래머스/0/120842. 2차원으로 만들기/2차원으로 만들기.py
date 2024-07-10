def solution(num_list, n):
    answer = []
    tmp = []
    for item in num_list:
        tmp.append(item)
        if(len(tmp)==n):
            answer.append(tmp)
            tmp = []
    return answer