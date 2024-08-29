
def LocalInput():
    with open('input.txt', 'r') as file:
        data = list(map(int, file.readline().split()))
    return data
            
def BaekjoonInput():
    data = list(map(int, input().split()))
    return data

# data = LocalInput() # 로컬입력
data = BaekjoonInput() # 백준입력

state = "wait"

for i in range(1, len(data)):
    if state=="wait":
        state = "ascending" if data[0]<data[i] else "descending"
        continue
    if state=="ascending":
        if(data[i-1]>data[i]):
            state = "mixed"
    if state=="descending":
        if(data[i-1]<data[i]):
            state = "mixed"
print(state)