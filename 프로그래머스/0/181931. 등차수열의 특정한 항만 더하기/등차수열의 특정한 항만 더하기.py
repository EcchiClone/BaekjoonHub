def solution(a, d, included):
    answer = sum([a+d*i for i in range(len(included)) if included[i]==True])
    return answer