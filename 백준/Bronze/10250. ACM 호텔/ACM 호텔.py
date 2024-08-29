def LocalInput():
    with open('input.txt', 'r') as file:
        N = int(file.readline())
        datas = []
        for _ in range(N):
            data = file.readline().split()
            datas.append(data)
    return N, datas
            
def BaekjoonInput():
    N = int(input())
    datas = []
    for _ in range(N):
        data = input().split()
        datas.append(data)
    return N, datas

# N, datas = LocalInput() # 로컬입력
N, datas = BaekjoonInput() # 백준입력

for data in datas:
    h, w, n = map(int, data)
    setH = str((n-1)%h + 1)
    setW = str(((n-1)//h) + 1)
    setW = setW.zfill(2)
    print(setH+setW)
    
