def solution(arr):
    answer = []
    d1 = len(arr)
    d2 = len(arr[0])
    if d1>=d2:
        d = d1-d2
        for item in arr:
            aitem = item + [0 for _ in range(d)]
            answer.append(aitem)
    else:
        d = d2-d1
        answer = arr[:]
        for _ in range(d):
            answer.append([0 for _ in range(d2)])
    
    return answer