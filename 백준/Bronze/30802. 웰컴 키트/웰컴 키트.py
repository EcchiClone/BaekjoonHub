def LocalInput():
    with open('input.txt', 'r') as file:
        N = int(file.readline())
        datas = map(int, file.readline().split())
        T, P = map(int, file.readline().split())
    return N, datas, T, P
            
def BaekjoonInput():
    N = int(input())
    datas = map(int, input().split())
    T, P = map(int, input().split())
    return N, datas, T, P

# N, datas, T, P = LocalInput() # 로컬입력
N, datas, T, P = BaekjoonInput() # 백준입력

out1, out2, out3 = 0,0,0

for data in datas:
    out1 += ( (data-1) // T + 1 )

out2 = N // P
out3 = N % P

print(out1)
print(out2, out3)
