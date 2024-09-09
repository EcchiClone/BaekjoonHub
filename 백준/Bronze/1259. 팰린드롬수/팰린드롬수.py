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

for data in datas[:-1]:
    if data == data[::-1]:
        print("yes")
    else: print("no")