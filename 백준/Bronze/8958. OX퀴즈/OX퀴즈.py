def LocalInput():
    with open('input.txt', 'r') as file:
        N = int(file.readline())
        datas = []
        for _ in range(N):
            data = file.readline()
            datas.append(data)
    return N, datas
            
def BaekjoonInput():
    N = int(input())
    datas = []
    for _ in range(N):
        data = input()
        datas.append(data)
    return N, datas

# N, datas = LocalInput() # 로컬입력
N, datas = BaekjoonInput() # 백준입력

for data in datas:
    score = 0
    added = 0
    for c in data:
        if c=="O":
            added += 1
            score += added
        else:
            added = 0
    print(score)