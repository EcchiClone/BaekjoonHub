def LocalInput():
    with open('input.txt', 'r') as file:
        datas = []
        for _ in range(3):
            data = int(file.readline())
            datas.append(data)
    return datas
            
def BaekjoonInput():
    datas = []
    for _ in range(3):
        data = int(input())
        datas.append(data)
    return datas

# datas = LocalInput() # 로컬입력
datas = BaekjoonInput() # 백준입력

calInt = 0
calStr = 0

calInt = datas[0] + datas[1] - datas[2]
calStr = int(str(datas[0]) + str(datas[1])) - datas[2]

print(calInt)
print(calStr)