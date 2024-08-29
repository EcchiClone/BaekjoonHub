
def LocalInput():
    with open('input.txt', 'r') as file:
        N, M = map(int, file.readline().split())
        board = []
        for _ in range(N):
            row = file.readline().strip()
            board.append(row)
    return N, M, board
            
def BaekjoonInput():
    N, M = map(int, input().split())
    board = []
    for _ in range(N):
        row = input().strip()
        board.append(row)
    return N, M, board

# N, M, board = LocalInput() # 로컬입력
N, M, board = BaekjoonInput() # 백준입력

min = 64
wordDict = {
    "0":"B",
    "1":"W",
}
for i in range(N-7):
    for j in range(M-7):
        sv = 0
        for a in range(8):
            for b in range(8):
                sv += 1 if (board[i+a][j+b] == wordDict[str((a+b)%2)]) else 0
                # print(board[i+a][j+b],end="")
            # print()
            
        if sv>32: sv = 64 - sv
        if sv<min: min = sv
        # print(sv)
        # print()
        
print(min)