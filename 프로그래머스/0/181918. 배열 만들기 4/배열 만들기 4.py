def solution(arr):
    stk = []
    i = 0
    while(i<len(arr)):
        if(stk==[]):
            stk.append(arr[i])
            i += 1
        elif(stk!=[]):
            if(stk[-1]<arr[i]):
                stk.append(arr[i])
                i += 1
            else:
                stk = stk[:-1]
    return stk