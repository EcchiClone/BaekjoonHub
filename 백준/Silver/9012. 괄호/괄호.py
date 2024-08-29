
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

from collections import deque

for data in datas:
    
    stack = deque()
    
    result = True
    
    for c in data:
        if c=="(":
            stack.append("(")
            # print(''.join(list(stack)), end="\t")
        elif c==")":
            if(stack):
                stack.pop()
                # print(''.join(list(stack)), end="\t")
            else:
                result = False
                break
            
    if(result==False): print("NO")
    else:
        if(stack): print("NO")
        else: print("YES")
    
