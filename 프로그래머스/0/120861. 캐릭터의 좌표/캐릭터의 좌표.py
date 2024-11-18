def solution(keyinput, board):
    
    answer = []
    
    start_pos = [0,0]
    
    input_dict = {
        "left":[-1,0],
        "right":[1,0],
        "up":[0,1],
        "down":[0,-1]
    }
    
    next_pos = start_pos
    
    for command in keyinput:
        next_pos = listSum(next_pos, input_dict[command])
        outCheck(board, next_pos)
        
    return next_pos

def listSum(l1, l2):
    return [v1+v2 for v1, v2 in zip(l1, l2)]

def outCheck(board, pos):
    minX = -(board[0]//2)
    maxX = board[0]//2
    minY = -(board[1]//2)
    maxY = board[1]//2
    pos[0] = max(pos[0],minX)
    pos[0] = min(pos[0],maxX)
    pos[1] = max(pos[1],minY)
    pos[1] = min(pos[1],maxY)
    