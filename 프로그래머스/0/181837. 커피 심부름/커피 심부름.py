def solution(order):
    answer = 0
    for item in order:
        if('cafe' in item):
            answer += 5000
        else:
            answer += 4500
    return answer