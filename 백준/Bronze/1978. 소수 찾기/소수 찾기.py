import math
def LocalInput():
    with open("input.txt") as file:
        N = int(file.readline())
        datas = list(map(int, file.readline().split()))
    return N, datas
def BaekjoonInput():
    N = int(input())
    datas = list(map(int, input().split()))
    return N, datas

# N, datas = LocalInput()
N, datas = BaekjoonInput()

counter = 0

for data in datas:
    
    if data==1:
        counter += 1
        continue
    
    for i in range(2, 1 + int(math.sqrt(data))):
        if(data%i==0):
            counter += 1
            break

print(N-counter)