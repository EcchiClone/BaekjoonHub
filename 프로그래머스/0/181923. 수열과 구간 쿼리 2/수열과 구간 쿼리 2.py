def solution(arr, queries):
    answer = []
    for q in queries:
        result = -1
        for i in range(q[0],q[1]+1):
            if arr[i]>q[2] and (result==-1 or arr[i]<result):
                result = arr[i]
        answer.append(result)
    
    return answer