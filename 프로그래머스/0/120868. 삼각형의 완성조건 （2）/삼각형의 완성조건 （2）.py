def solution(sides):
    answer = 0
    cre = sides[0]+sides[1]
    dim = sides[0]-sides[1]
    if dim < 0 : dim = -dim
    answer = cre - dim - 1
    
    
    return answer