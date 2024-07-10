def solution(my_string):
    answer = ''
    already = ''
    for c in my_string:
        if c in already:
            pass
        else:
            answer += c
            already += c
    return answer