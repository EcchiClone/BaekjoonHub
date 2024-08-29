
def LocalInput():
    with open('input.txt', 'r') as file:
        datas = []
        for _ in range(3):
            data = file.readline()
            datas.append(data)
    return datas
            
def BaekjoonInput():
    datas = []
    for _ in range(3):
        data = input()
        datas.append(data)
    return datas

# datas = LocalInput() # 로컬입력
datas = BaekjoonInput() # 백준입력

mul = 1
for data in datas:
    mul *= int(data)
strMul = str(mul)
for i in range(10):
    print(strMul.count(str(i)))