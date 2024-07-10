def solution(before, after):
    answer = 0
    e_before = sorted(before)
    e_after = sorted(after)
    if(e_before == e_after):
        answer = 1
    return answer