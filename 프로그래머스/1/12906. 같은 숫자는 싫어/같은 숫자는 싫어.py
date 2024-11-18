def solution(arr):
    answer = []
    nowNum = -1
    for item in arr:
        if nowNum != item:
            answer.append(item)
            nowNum = item
    return answer