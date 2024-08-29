def LocalInput():
    with open('input.txt', 'r') as file:
        datas = []
        while True:
            line = file.readline().strip()
            if not line:
                break
            data = list(map(int, line.split()))
            datas.append(data)
    return datas
            
def BaekjoonInput():
    datas = []
    try:
        while True:
            line = input().strip()
            if not line:
                break
            data = list(map(int, line.split()))
            datas.append(data)
    except EOFError:
        pass
    return datas

# datas = LocalInput() # 로컬입력
datas = BaekjoonInput() # 백준입력

for data in datas:
    data.sort()
    if sum(data)==0:
        break
    if(data[0]**2 + data[1]**2 == data[2]**2):
        print("right")
    else:
        print("wrong")

