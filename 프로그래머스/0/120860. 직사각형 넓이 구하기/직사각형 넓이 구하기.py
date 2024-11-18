def solution(dots):
    answer = 0
    
    minX, maxX, minY, maxY = dots[0][0],dots[0][0],dots[0][1],dots[0][1]
    for i in range(1,len(dots)):
        minX = min(minX,dots[i][0])
        maxX = max(maxX,dots[i][0])
        minY = min(minY,dots[i][1])
        maxY = max(maxY,dots[i][1])
    
    answer = (maxX-minX)*(maxY-minY)
    
    return answer