import math
def LocalInput():
    with open("input.txt") as file:
        N, M = map(int, file.readline().split())
        datas = list(map(int, file.readline().split()))
    return N, M, datas
def BaekjoonInput():
    N, M = map(int, input().split())
    datas = list(map(int, input().split()))
    return N, M, datas

# N, M, datas = LocalInput()
N, M, datas = BaekjoonInput()
result = 0
for i in range(N):
    for j in range(i+1, N):
        for k in range(j+1, N):
            sumNum = datas[i]+datas[j]+datas[k]
            if sumNum<=M and result<sumNum:
                result = sumNum

print(result)