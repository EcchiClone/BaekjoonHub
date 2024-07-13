def solution(arr, k):
    answer = []
    for item in arr:
        if item not in answer:
            answer.append(item)
            if(len(answer)==k):
                break
    answer += [-1 for _ in range(max(0,k-len(answer)))]
    return answer