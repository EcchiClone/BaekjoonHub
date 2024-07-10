def solution(strArr):
    answer = 0
    d = {}
    maxV = 0
    for st in strArr:
        if str(len(st)) in d:
            d[str(len(st))]+=1
        else:
            d[str(len(st))]=1
    for value in d.values():
        if maxV < value:
            maxV = value
    answer = maxV
    return answer