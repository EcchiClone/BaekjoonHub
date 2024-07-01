def solution(numbers):
    answer = 0
    sortedN = sorted(numbers)
    print(sortedN)
    answer = max(sortedN[0]*sortedN[1], sortedN[-1]*sortedN[-2])
    return answer