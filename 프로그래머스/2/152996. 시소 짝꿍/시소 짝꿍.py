from bisect import bisect_left, bisect_right

def solution(weights):
    
    answer = 0
    
    mul = [2/4, 2/3, 3/4, 1/1, 4/3, 3/2, 4/2]
    
    # 1. 퀵정렬
    weights.sort()
    # print(weights)
    
    # 2. 이진탐색
    for i in range(len(weights)):
        target = [int(weights[i]*m) for m in mul if(weights[i]*m%1==0)]
        # print(target)
        for j in range(len(target)):
            cnt = count_by_range(weights,target[j],target[j])
            # print(target[j], cnt)
            if(cnt>0):
                answer += cnt
        answer -= 1
    answer /= 2
    return answer

def count_by_range(a, left_value, right_value):
    right_index = bisect_right(a,right_value)
    left_index= bisect_left(a,left_value)
    return right_index - left_index