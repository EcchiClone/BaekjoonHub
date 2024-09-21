import sys
def LocalInput():
    with open("input.txt") as file:
        datas = file.read().strip().splitlines()
    return datas
def BaekjoonInput():
    datas = sys.stdin.read().strip().splitlines()
    return datas

# datas = LocalInput()
datas = BaekjoonInput()

M = 1234567891

def myOrd(c):
    return ord(c) - ord('a') + 1

data = datas[1]
sum = 0
for i in range(len(data)):
    sum += myOrd(data[i])*(31**i) % M
    sum %= M

print(sum)