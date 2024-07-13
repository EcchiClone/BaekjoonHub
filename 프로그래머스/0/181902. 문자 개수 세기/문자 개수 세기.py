def solution(my_string):
    answer = [0 for _ in range(52)]
    for c in my_string:
        cti = ord(c)-71 if ord(c) > 90 else ord(c)-65
        answer[cti] += 1
    return answer