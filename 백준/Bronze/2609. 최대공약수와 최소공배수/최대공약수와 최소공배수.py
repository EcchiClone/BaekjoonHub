import sys, math
def LocalInput():
    with open("input.txt") as file:
        datas = file.read().strip().splitlines()
    return datas
def BaekjoonInput():
    datas = sys.stdin.read().strip().splitlines()
    return datas

# datas = LocalInput()
datas = BaekjoonInput()

datas = list(map(int,datas[0].split()))

print(math.gcd(datas[0],datas[1]))
print(math.lcm(datas[0],datas[1]))