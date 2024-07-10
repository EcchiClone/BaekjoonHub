def solution(arr):
    answer = 0
    count = 0
    while(True):
        isContinue = False
        for i in range(len(arr)):
            if(arr[i]>=50 and arr[i]%2==0):
                isContinue = True
                arr[i] /= 2
                continue
            elif(arr[i]<50 and arr[i]%2 ==1):
                isContinue = True
                arr[i] = arr[i]*2+1
                continue
        if(isContinue==False):
            answer = count
            break
        count += 1
    
    return answer