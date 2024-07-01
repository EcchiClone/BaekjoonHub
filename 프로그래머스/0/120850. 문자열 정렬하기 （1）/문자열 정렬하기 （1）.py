def solution(my_string):
    answer = [int(a) for a in my_string if a.isdigit() ]
    answer.sort()
    return answer