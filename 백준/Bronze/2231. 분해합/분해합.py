import math
def LocalInput():
    with open("input.txt") as file:
        N = int(file.readline())
    return N
def BaekjoonInput():
    N = int(input())
    return N

# N = LocalInput()
N = BaekjoonInput()

자릿수 = len(str(N))
최소가능생성자 = N - 자릿수*9

result = 0

for i in range(max(0,최소가능생성자), N):
    분해합 = i + sum(int(n) for n in str(i))
    if 분해합==N:
        result = i
        break

print(result)